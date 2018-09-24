using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo8
    {
        //Textwriter is an abstract class
        public void Program8()
        {
            using (TextReader wr = File.OpenText("F:\\FileIo\\abc3.Txt"))
            {
                Console.WriteLine(wr.ReadToEnd());
            }
        }
    }
}
