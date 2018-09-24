using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo12
    {
        public void Program12()
        {
            DirectoryInfo dir = new DirectoryInfo(@"F:\\javatpoint");
            try
            {
                if (dir.Exists)
                {
                    Console.WriteLine("Directory already exists");
                }
                dir.Delete();
                Console.WriteLine("Directory deleted successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some thing is going wrong " + ex.ToString());
            }
        }
    }
}
