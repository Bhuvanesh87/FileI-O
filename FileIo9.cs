using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class FileIo9
    {
        public void Program9()
        {
            string fileName = "F:\\FileIo\\abc4.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write("Hello");
                writer.Write(2);
                writer.Write(true);
            }
            Console.WriteLine("Data inserted successfully");
        }
    }
}
