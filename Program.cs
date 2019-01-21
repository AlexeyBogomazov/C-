using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace Print
{
    class Program
    {
        public abstract class Printer
        {
            public abstract string txt { get; set; }

            public abstract void Print(string ln);

        }

       public class Cnsl : Printer
        {
            //public Dictionary<string, string> a = new Dictionary<string, string>();

            public override string txt { get; set; }

            public Cnsl(string j)
            {
                this.txt = j;
                
            }
            
         public override void Print(string ln)
            {
                this.txt = ln;
                Console.WriteLine(this.txt);
            }


        }

        public class Fl : Printer
        {
            public override string txt { get; set; }

            

            public Fl(string k)
            {
                this.txt = k;

            }

            public override void Print(string ln)
            {
                string path = @"F:\Study\C#\TrainingExample.txt";
                if (File.Exists(path))
                {
                   File.WriteAllText(path, ln);
                }

                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);

            }

        }

        public class Img : Printer
        {
            public override string txt { get; set; }



            public Img(string l)
            {
                this.txt = l;

            }

            public override void Print(string ln)
            {
                //Bitmap 


            }


        }









        static void Main(string[] args)
        {
            Console.WriteLine("Please, input your text:");
            string ILine = Console.ReadLine();

            int option;

            Console.WriteLine("Please, select method of output (1 - Console, 2 - File, 3 - Picture. 0 - Cancel):");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option){
                case 1: Cnsl m = new Cnsl(ILine);
                    m.Print(ILine);
                    break;
                case 2: Fl n = new Fl(ILine);
                    n.Print(ILine);
                    break;
                //case 3:
                

            }




        }
    }
}
