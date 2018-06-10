using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mFile_Yardi
{
    class Program
    {
        static void Main(string[] args)
        {
            // gets the path for the root directory, creates imported folder to move all imported files and all the xml files in that directory
            string currentPath = System.IO.Directory.GetCurrentDirectory();
            string importedPath = System.IO.Directory.GetCurrentDirectory() + @"\Imported-" + DateTime.Now.ToString("yyMMdd-hhmm");
            if (!System.IO.Directory.Exists(importedPath))
            {
                System.IO.Directory.CreateDirectory(importedPath);
            }

            string[] files = System.IO.Directory.GetFiles(currentPath, "*.xml");

            //start output file
            XElement output = new XElement("YsiTran");
            XElement payables = new XElement("Payables");

            //Get Post Month
            Console.WriteLine(@"Enter Post Month (05/18): ");
            string post = Console.ReadLine();

            //Add Payable elements to Payables
            foreach (string file in files)
            {
                string destination = importedPath + @"\" + System.IO.Path.GetFileName(file);
                XElement inputxml = XElement.Load(file);
                XElement payable = inputxml.Element("Payables").Element("Payable");
                payable.SetElementValue("PostMonth", post);
                payables.Add(payable);

                System.IO.Directory.Move(file, destination);
            }

            output.Add(payables);
            Console.WriteLine(output);
            output.Save("Yardi-Import.xml");

        }
    }
}
