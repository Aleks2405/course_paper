using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсовой_проект
{
    class Assembling
    {

        public string Yes_No { get; }
        private string Filepart { get; } = @"test.txt";
        private string Top_20 { get; } = @"luk1.txt";
        public int Number { get; }
        public string Login;
        public Assembling()
        {
           
            this.Yes_No = Yes_No;
            
           
                Console.WriteLine("Вы являетесь зарегистрированным пользователем: Да или Нет ");
                Yes_No = Console.ReadLine();

                if (Yes_No.ToLower() == "да" || Yes_No.ToLower() == "yes")  // вход по логину
                {
                    Console.WriteLine("Введите логин");
                    Login = Console.ReadLine();

                    Console.WriteLine("Введите пароль");
                    string Password = Console.ReadLine();

                    Registration one = new Registration(Login, Password);

                    string[] prov = File.ReadAllLines(Filepart);



                    for (int i = 0; i < prov.Length; i++)
                    {
                        if (prov[i].Contains(Login) && prov[i].Contains(Password))
                        {
                            Console.WriteLine("Вы успешно авторозировались");
                        }

                    }

                    Top(Login);
                    
                }
               
                else if (Yes_No.ToLower() == "нет" || Yes_No.ToLower() == "no") /*регистация нового пользователя*/
                {
                    Console.WriteLine("Пройдите этап регистрации");
                    Console.WriteLine("Введите логин");
                    Login = Console.ReadLine();

                    string[] prov = File.ReadAllLines(Filepart);



                    for (int i = 0; i < prov.Length; i++)
                    {
                        while (prov[i].Contains(Login))
                        {
                            Console.WriteLine("Данный логин уже занят введите другой");
                            Login = Console.ReadLine();
                        }
                    }
                    Top(Login);
                    Console.WriteLine("Введите пароль");
                    string Password = Console.ReadLine();


                    Console.WriteLine("Введите возраст");
                    string Age = Console.ReadLine();
                    Registration two = new Registration(Login, Password, Age);
                    Console.WriteLine(two.ToString());

                    using FileStream fs = new FileStream(Filepart, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.WriteLine($"{two.ToString()} { Password} {Age}");
                    sw.Close();
                    fs.Close();
                    
                }
                
            
            


            Console.WriteLine($"Меню, для выбора нажмите цифру соответствующую \n" +
                 $"0. Выход в главное меню \n" +
                  $"1. Старт новой викторины \n" +
                  $"2. Посмотреть результаты \n" +
                  $"3. Посмотреть топ 20 по конкретной викторине \n" +
                  $"4. Изменить логин или пароль \n" +
                  $"5. Выход \n");
            while (true)
            
            {
                
            Number = Int32.Parse(Console.ReadLine());
            
            
                Menu thee = new Menu(Number);   /*реализация меню*/
                try
                {
                    if (6 < Number)
                    {
                        Console.WriteLine("Введенное число больше повторите ввод");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                
            }

        }
    
            public void Top(string a)
            {
                FileStream fs = new FileStream(Top_20, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine(a);
                sw.Close();
                fs.Close();
            }
        }
    }

