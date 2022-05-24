using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Задание 2
//Создать приложение «Викторина».
//Основная задача проекта: предоставить пользователю возможность проверить свои 
//знания в разных областях
namespace Курсовой_проект
{
   public class Registration
    {
        private string Login { get; set; }
       private string Password { get; set; }
        private string Age { get; set; } 
        public Registration() { }
        public Registration(string a, string b)
        {
            Login = a;
            Password = b;           
        }
        
        public Registration(string login, string password, string age)
        {
            Login = login;
            Password = password;
            Age = age;

        }
        public override string ToString()
        {
            return $"{Login}";
        }
       

    }
}
