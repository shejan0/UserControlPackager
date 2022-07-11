using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Concurrent;

namespace UserControlPackager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static ConcurrentQueue<Package> packages;
        public static int created=0, destroyed=0;
        static String filename = "packageData.txt";
        static Form1 form;
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                filename = args[0];
            }   
            initLoadFile();   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);
        }
        public static void addPackage(Package package)
        {
            packages.Enqueue(package);
            form.refreshList();
            created++;
            writeFile();
        }
        public static Package removeTopPackage()
        {
            if(packages.TryDequeue(out Package removed))
            {
                form.refreshList();
                destroyed++;
                writeFile();
                return removed;
            }
            else
            {
                return null;
            }
            
        }
        static void initLoadFile()
        {
            if (File.Exists(filename))
            {
                FileStream file = File.OpenRead(filename);
                StreamReader reader = new StreamReader(file);
                String header = reader.ReadLine();
                string[] data = header.Split(',');
                int.TryParse(data[0], out created);
                int.TryParse(data[1], out destroyed);
                int s;
                int.TryParse(data[2], out s);
                List<Package> list = new List<Package>();
                for (int n = 0; n < s; n++)
                {
                    list.Add(JsonConvert.DeserializeObject<Package>(reader.ReadLine()));
                }
                reader.Close();
                packages = new ConcurrentQueue<Package>(list);
            }
            else
            {
                packages = new ConcurrentQueue<Package>();
            }
        }
        public static void writeFile()
        {
            try
            {
                FileStream file = File.Create(filename);
                file.Seek(0, SeekOrigin.Begin);
                
                StreamWriter writer = new StreamWriter(file);
                //header to document
                writer.WriteLine(created + "," + destroyed + "," + packages.Count);
                foreach(Package s in packages)
                {
                    writer.WriteLine(JsonConvert.SerializeObject(s));
                }
                writer.Close();
            }catch(Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            

        }
        public static void printQueue()
        {
            Console.WriteLine("Current Length of Queue: " + packages.Count);
            foreach (Package s in packages)
            {
                Console.WriteLine(s.ToShippingLabelString());
            }
        }
    }
}
