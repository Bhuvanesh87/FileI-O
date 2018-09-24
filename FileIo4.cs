using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo4
    {
        public void Program4()
        {
            FileStream f3 = new FileStream("F:\\FileIo\\abc2.txt", FileMode.Create);
            StreamWriter s1 = new StreamWriter(f3);
            s1.WriteLine("Hello how are you");
            s1.Close();
            f3.Close();
            Console.WriteLine("File created successfully");
        }
    }
}
