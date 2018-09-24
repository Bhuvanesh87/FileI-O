using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo6
    {
        public void Program6()
        {
            FileStream f5 = new FileStream("F:\\FileIo\\abc2.txt", FileMode.OpenOrCreate);
            StreamReader s3 = new StreamReader(f5);
            string Line = "";
            while ((Line = s3.ReadLine()) != null)
            {
                Console.WriteLine(Line);
            }
            s3.Close();
            f5.Close();
        }
    }
}
