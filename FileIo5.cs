using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo5
    {
        public void Program5()
        {
            FileStream f4 = new FileStream("F:\\FileIo\\abc2.txt", FileMode.OpenOrCreate);
            StreamReader s2 = new StreamReader(f4);

            string line = s2.ReadLine();
            Console.WriteLine(line);
            s2.Close();
            f4.Close();

        }
    }
}
