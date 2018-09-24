using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FileIo14
    {
        public void Program14()
        {
            string inFileName = null;
            Console.WriteLine("Enter the name of the file to process:");
            inFileName = Console.ReadLine();
            StreamReader sr = new StreamReader(inFileName);
            int counter = 0;
            string delim = " ,. '' ";
            string[] fields = null;
            string line = null;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;
            }
            sr.Close();
            Console.WriteLine("The word count is " + counter);
        }
    }
}
