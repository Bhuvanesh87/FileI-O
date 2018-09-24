using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo7
    {
        public void Program7()
        {
            using (TextWriter Wr = File.CreateText("F:\\FileIo\\abc3.txt"))
            {
                Wr.WriteLine("Welcome to BizRunTime");
                Wr.WriteLine("Hello how are you");

            }
            Console.WriteLine("File writen sucessfully");

        }
    }
}
