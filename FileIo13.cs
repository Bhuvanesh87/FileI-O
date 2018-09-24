using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo13
    {
        public void Program13()
        {
            var lineCount = 0;
            using (var reader = File.OpenText(@"F:\\FileIo\\abc5.txt"))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            Console.WriteLine("The total number of line in given file is "+lineCount);

            
            


        }
    }
}
