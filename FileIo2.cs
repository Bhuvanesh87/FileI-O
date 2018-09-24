using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class FileIo2
    {        
         public void Program2()
         { 

                 FileStream f1 = new FileStream("F:\\FileIo\\abc1.txt", FileMode.OpenOrCreate);
                 for (int i = 65; i <= 90; i++)
                 {
                     f1.WriteByte((byte)i);
                 }
                 f1.Close();       

          }
    }
}
