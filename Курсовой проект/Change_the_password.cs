using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсовой_проект
{
    class Change_the_password : Registration
    {
        private string Filepart { get; } = @"test.txt";
        public Change_the_password(string a, string b) : base(a, b)
        {
            string[] prov = File.ReadAllLines(Filepart);

            for (int i = 0; i < prov.Length; i++)
            {
                if (prov[i].Contains(a) && prov[i].Contains(b))
                {

                    Console.WriteLine("Введите новый логин");
                    string number = Console.ReadLine();
                    prov[i] = prov[i].Replace(a, number);


                    FileStream fs = new FileStream(Filepart, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.WriteLine($"{prov[i]}");
                    sw.Close();
                    fs.Close();
                    Console.WriteLine("Вы успешно изменили логин");
                }
            }

        }
    }
}
