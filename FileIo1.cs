using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    public  class FileIo1
    {
        public void Program1()
        { 
            FileStream f = new FileStream("F:\\FileIo\\abc.txt", FileMode.OpenOrCreate);//creating file stream  
            f.WriteByte(65);//writing byte into stream  
             f.Close();//closing stream        


        }
    }
}
