using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсовой_проект
{
    class Geography : IQuiz
    {
       

        public string Filepart_geor { get;  } = @"geography.txt";
        public string Filepart_geor1 { get; } = @"o_geography.txt";
        private string Filepart_geor2 { get; } = @"luk.txt";
        private string Top_20 { get; } = @"luk1.txt";

        public int Count_ { get; set; } = 0;

        public string Word { get; set; }

        public Geography()
        {      
            
            string[] prov = File.ReadAllLines(Filepart_geor);
            string[] prov1 = File.ReadAllLines(Filepart_geor1);
            int j = 0;
            for(int i = 0; i < prov.Length; i++)
            {
                Console.WriteLine(prov[i]);
                Word = Console.ReadLine();
               
                    if (prov1[j].ToLower() == Word.ToLower())
                    {
                        Count_++;
                    }
                j++;                          
            }
            Console.WriteLine("правильные ответы " + Count_);
            one();
            Top();
            
           
        }

        public void one ()
        {         
            FileStream fs = new FileStream(Filepart_geor2, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine($" География рузультаты правильных ответов = {Count_}");
            sw.Close();
            fs.Close();           
        }
        public void qwe()
        {
            string[] prov = File.ReadAllLines(Filepart_geor2);

            foreach(var aew in prov)
            {
                Console.WriteLine(aew);
                
            }
           
            
        }
        public void Top()
        {
            FileStream fs = new FileStream(Top_20, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine($" География рузультаты правильных ответов = {Count_}");
            sw.Close();
            fs.Close();
        }


    }
}
