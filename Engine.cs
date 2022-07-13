using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega_Jarvis
{
    public static class Engine
    {
        public static string GetNode()
        {
            string getNode = "";
            Process process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = @"/C chcp 65001 & openfiles.exe /query /s ts-fs /FO CSV";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            if ((process.StandardOutput != null))
            {
                var result = process.StandardOutput.ReadToEnd().Trim().Replace("\"", "");
                var lines = result.Split('\n');

                foreach (var line in lines)
                {
                    if (line.Contains("S-1-5-21-2657382475-1131176568-1475707238-25943"))
                    {
                         string[] array = line.Split(',');
                         getNode = array[1].Replace("$","").ToLower();
                    }                                       
                }

            }

            return getNode;

        }
    }
}
