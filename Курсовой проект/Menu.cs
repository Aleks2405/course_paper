using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Курсовой_проект
{

    class Menu
    {
        public delegate void Pd(); //использование делега 
        public event Pd aa; // событие на данный делегат

        private int Number { get; set; }
       
        private string Filepart_geor2 { get; } = @"luk.txt";  // общий файл для просмотра личных результатов
        private string Top_20 { get; } = @"luk1.txt";    // просмотр топ 20

        public Menu(int a)
        {
            Number = a;
            switch (a)
            {
                case 0:
                    Console.WriteLine(vvod());
                    break;
                case 1:
                    Console.WriteLine("Старт новой викторины");
                    
                    aa += Start_a_new_quiz;
                    aa();
                    break;
                case 2:
                    View_results();
                    break;
                case 3:
                    aa +=(View_the_top_20_for_a_specific_guiz);
                    aa();
                    break;
                case 4:
                    aa = new(Change_Settings);
                    aa();
                    break;
                case 5:
                    Exit();
                    break;
            }
        }
        public Menu() { }
        Geography geography;
        History history;
        
        public void Start_a_new_quiz()
        {
            Console.WriteLine($"Выбирете викторину которую вы хотите пройти \n" +
                $"1. География \n" +
                $"2. История");
            int a;
            a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    geography = new Geography();
                    break;
                case 2:
                    history = new History();
                    break;
            }
           


        }
       public void View_results()
        {
            Console.WriteLine("Личные результаты викторины");


            string[] prov = File.ReadAllLines(Filepart_geor2);

            foreach (var aew in prov)
            {
                Console.WriteLine(aew);

            }

        }
        void View_the_top_20_for_a_specific_guiz()
        {
            Console.WriteLine("Посмотреть топ 20 по конкретно викторине");

            string[] prov = File.ReadAllLines(Top_20);

            foreach (var aew in prov)
            {
                Console.WriteLine(aew);

            }
        }
        void Change_Settings()
        {
            Console.WriteLine("Введите логин который хоите поменять");
            string a = Console.ReadLine();
            Console.WriteLine("Пароль подтверждающий что это ваша учетная запись");
            string b = Console.ReadLine();
            Change_the_password change_The_Password = new Change_the_password(a, b);
        }
        void Exit()
        {

            Console.WriteLine("Вы успешно вышли");  /*как то лучше не придумал*/
            
            
        }

        string vvod()
        {
            return $"Меню, для выбора нажмите цифру соответствующую \n" +
                    $"0. Выход в главное меню \n" +
                    $"1. Старт новой викторины \n" +
                    $"2. Посмотреть результаты \n" +
                    $"3. Посмотреть топ 20 по конкретной викторине \n" +
                    $"4. Изменить логин или пароль \n" +
                    $"5. Выход \n";
        }

    }
}
