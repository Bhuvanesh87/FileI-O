using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class FileIo10
    {
        public void Program10()
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {

            using (BinaryWriter writer = new BinaryWriter(File.Open("F:\\FileIo\\abc5.txt", FileMode.Create)))
            {
                writer.Write("Hello welcome to the BIzRuntime");
                writer.Write(2.5);
                writer.Write(true);
                // writer.Write("Hello welcome to the BIzRuntime from Banglore");
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader Reader = new BinaryReader(File.Open("F:\\FileIo\\abc5.txt", FileMode.Open)))
            {
                Console.WriteLine("Sting " + Reader.ReadString());
                Console.WriteLine("Double value is " + Reader.ReadDouble());
                Console.WriteLine("Boolean value is " + Reader.ReadBoolean());
            }
        }
    }
}
