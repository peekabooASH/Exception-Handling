using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr= null;
            try
            {
                sr = new StreamReader("d:/testing1.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                
            }
            catch (FileNotFoundException exceptionObj)
            {
                Console.WriteLine(exceptionObj.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
