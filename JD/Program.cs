using RDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace JD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".png");
            //Application.ThreadExit += (sender, e) => {
            //    try
            //    {
            //        File.Delete(path);
            //    }
            //    finally { }
            //};


            //var appSettings = ConfigurationManager.AppSettings;

            //string rpath = appSettings["RPATH"];
            //string rhome = appSettings["RHOME"];

            //REngine.SetEnvironmentVariables(rpath,rhome);
            //REngine rengine = REngine.GetInstance();

            //Application.ThreadExit += (sender, e) => rengine.Dispose();

            //rengine.Initialize();

            //var form = new plotForm()
            //{
            //    Code = @"plot(1:10, pch=1:10, col=1:10, cex=seq(1, 2, length=10))
            //      text(c(1), c(1), c('Text here'), col=c('red'))",
            //    TempImagePath = path,
            //    Engine = rengine,
            //};

            
            //load required libs
            //rengine.Evaluate("source('libs.R')");

            //Application.Run(form);
            Application.Run(new MenuForm());
        }
    }
}
