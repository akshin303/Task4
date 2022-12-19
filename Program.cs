using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string name = Console.ReadLine();
            Console.WriteLine((Count(name)));
        }
        static int Count(string name)
        {
            //- Verilmiş string dəyərdəki sözlərin sayını tapan metod 
            string[] name2 = name.Split(' ');
            int count = 0;
            for(int i=0;i<name2.Length;i++)
            {
                if (name2[i] != "")
                    count++;
            }

            return count;
        }
        //Verilmiş string dəyərindəki bütün sözlərin arasında bir boşluq qalacaq vəziyyətə salan metod.
        static void Spaceremover (string name)

        {


            var count = name1.Count();
            
            string[] name2 = name1.Split(' ');

          


            string[] newname = new string[count+(count-1)];
            int j = 0;
            for(int i=0;i<name2.Length;i++)
            {
                if (name2[i]!="0")
                {
                    newname[j] = name2[i];
                }
                


            }
            for(j=0;j<newname.Length;j++)
            {

                Console.WriteLine(newname[j]);
            }
            


            
        }

    }
}
