using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo11
    {
        public void Program11()
        {
            DirectoryInfo dir = new DirectoryInfo(@"F:\\javatpoint");
            try
            {
                // Check, directory exist or not.  
                if (dir.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                // Creating a new directory.  
                dir.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created:"+ e.ToString());
            }
        }
    }
}
