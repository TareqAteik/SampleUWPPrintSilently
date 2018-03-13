using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Win32Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfProcess = new System.Diagnostics.Process();
            pdfProcess.StartInfo.FileName = @"FoxitReader.exe";
            var fileToPrint = ApplicationData.Current.LocalSettings.Values["FileToPrint"];
            pdfProcess.StartInfo.Arguments = string.Format("-t \"{0}\" \"{1}\"", fileToPrint, "Microsoft Print to PDF");
            pdfProcess.Start();
        }
    }
}
