using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("argument is null");
            }
            else
            {
                try
                {
                    string FilePath = args[0];

                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader(FilePath);

                    //call ListName function and getSorted extension method (CustomExtensions)
                    var SortedNames = ListName(sr).getSorted();

                    //clear content file
                    File.WriteAllText(FilePath, string.Empty);

                    //write sorted names to file
                    using (StreamWriter writer = new StreamWriter(FilePath))
                    {
                        foreach(var line in SortedNames)
                        {
                            writer.WriteLine(line);
                            Console.WriteLine(line);
                        }
                    }

                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }

        static List<string> ListName(StreamReader sr)
        {
            //define variable
            List<string> Names = new List<string>();
            string line;

            //Read the first line of text
            line = sr.ReadLine();

            //Continue to read until you reach end of file
            while (line != null)
            {
                //Add line of text to list string
                Names.Add(line);
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();

            //return the result
            return Names;
        }
    }
}
