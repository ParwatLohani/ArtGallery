using System.Drawing;
using System.IO;

namespace ArtGallery
{
    public static class Logevents
    {
        public static void LogToFile(string title, string logmessage, IWebHostEnvironment env)
        {
            
            string sPath = env.WebRootPath + "\\" + "LogFolder";
            
            bool direxists = Directory.Exists(sPath);

            if (!direxists)
            {
                Directory.CreateDirectory(sPath);

            }
            StreamWriter swriter;

            string filename = DateTime.Now.ToString("ddMMyyyy") + ".txt";
            String logpath = Path.Combine(sPath, filename);

            if (!File.Exists(logpath))
            {
                swriter = new StreamWriter(logpath);
            }
            else
            { 
                swriter=File.AppendText(logpath);
            }
            swriter.WriteLine("Log Entry");
            swriter.WriteLine("{0}{1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            swriter.WriteLine(":");
            swriter.WriteLine("Message Title : {0}", title);
            swriter.WriteLine("Message : {0}", logmessage);
            swriter.WriteLine("--------------------------------------------");
            swriter.Close();
        }
    }
}
