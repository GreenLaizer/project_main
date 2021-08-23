using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {

        static bool CheckNum(string number, out int currnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    currnumber = intnum;
                    return true;

                }


            }

            Console.WriteLine("Вы ввели некорректное значение");
            currnumber = 0;
            return false;

        }



        static bool CheckRussian(char ch)
        {
            if (((ch >= 'А') && (ch <= 'Я')) || ((ch >= 'а') && (ch <= 'я')) || (ch == 'ё') || (ch == 'Ё'))
            {
                return true;
            }
            else
                return false;

        }

        static bool F(string s)
        {
            bool flag = true;
            foreach (var item in s)
            {
                if (!CheckRussian(item))
                {
                    flag = false;
                    break;
                }
            }


            return flag;

        }

        public static string[] Pet()
        {
            int n = 3;
            var pet = new string[n];


            for (int i = 0; i < pet.Length; i++)
            {
                pet[i] = Console.ReadLine();
            }
            return pet;


        }
        public static string[] Color()
        {
            int n = 3;
            var color = new string[n];

            for (int i = 0; i < color.Length; i++)
            {
                color[i] = Console.ReadLine();
            }
            return color;
        }

        public static (string Name, string LastName, int Age, bool HasPet, string[] favColors) FuncUser()
        {
            (string Name, string LastName, int Age, bool HasPet, string[] favColors) User;


            User = default;

            bool v = false;

            Console.WriteLine("Введите Ваше имя");
            while (!v)
            {
                User.Name = Console.ReadLine();
                v = F(User.Name);
                if (!v)
                {
                    Console.WriteLine("Неправильный ввод. Введите еще раз");
                    continue;
                }
                Console.WriteLine(v);
            }



            bool d = false;
            Console.WriteLine("Введите Вашу Фамилию");
            while (!d)
            {
                User.LastName = Console.ReadLine();
                d = F(User.LastName);
                if (!d)
                {
                    Console.WriteLine("Неправильный ввод. Введите еще раз");
                    continue;
                }
                Console.WriteLine(d);
            }

            string age;
            int intage;
            bool l = false;
            Console.WriteLine("Введите возраст цифрами");
            while (!l)
            {
                age = Console.ReadLine();

                l = CheckNum(age, out intage);


                if (!l)
                {
                    Console.WriteLine("Неправильный ввод. Введите еще раз");
                    continue;
                }
                Console.WriteLine(l);
                User.Age = intage;
            }


            Console.WriteLine("Есть ли у Вас домашние животные Да/Нет");


            string answer = Console.ReadLine();
            if (answer == "Да")
            {
                User.HasPet = true;

            }
            else if (answer == "Нет")
            {
                User.HasPet = false;


            }

            Console.WriteLine("Введите три Ваших любимых цвета");
            string[] values = Color();

            Console.WriteLine($"{User.Name} = Имя, {User.LastName} = Фамилия, {User.Age} = Возраст, {User.HasPet} - Наличие питомца");



            Console.WriteLine("Ваши любимые цвета");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);

            }

            return User;

        }




        static void Main(string[] args)
        {

            FuncUser();
            Console.Read();

        }

    }
}
