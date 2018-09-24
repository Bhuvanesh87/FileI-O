using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo3
    {
        public void Program3()
        {
            FileStream f2 = new FileStream("F:\\FileIo\\abc1.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = f2.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f2.Close();
        }
    }
}
