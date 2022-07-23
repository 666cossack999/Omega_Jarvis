using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Omega_Jarvis
{
    public static class OmegaClient
    {
        public static string GetVersion(string uriVersion)
        {
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(uriVersion);
            req.Credentials = new NetworkCredential("omegajarvis", "wtvbrjns");
            req.EnableSsl = true;
            WebResponse res = req.GetResponse();
            Stream str = res.GetResponseStream();
            StreamReader tr = new StreamReader(str);
            return tr.ReadLine();
        }

        public static void DownloadFile(string uriFile, Action<long> setMaximumToProgressBar, Action progressBarValueStep)
        {
            FtpWebRequest client = (FtpWebRequest)WebRequest.Create(uriFile);
            client.Credentials = new NetworkCredential("omegajarvis", "wtvbrjns");
            client.EnableSsl = true;
            client.Method = WebRequestMethods.Ftp.DownloadFile;
            FtpWebResponse response = (FtpWebResponse)client.GetResponse();
            Stream stream = response.GetResponseStream();
            setMaximumToProgressBar(response.ContentLength);

            List<byte> list = new List<byte>();
            int b;
            while ((b = stream.ReadByte()) != -1)
            {
                list.Add((byte)b);
                progressBarValueStep();
            }

            File.WriteAllBytes(@"Update Test.rar", list.ToArray());
        }
    }
}
