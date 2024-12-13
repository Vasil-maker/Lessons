using System;

namespace Lesson_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Задание 1:
            Console.WriteLine("Введите ваше ФИО");
            string name = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            string date = Console.ReadLine();

            Console.Write($"Ваши данные: {name} {date} года рождения");

            Console.WriteLine("\n-----------\n");

            //Задание 2: Генератор стихов
            List<string> noun = new List<string>() { "Звезда", "Море", "Луна", "Дождь",
                "Ветер", "Песня", "Свет", };

            List<string> verb = new List<string>() { "Дышит","Горит","Манит","Спит", 
            "Пораждает", "Сверкает", "Утомляет"};

            Random rand = new Random();

            for(int i = 0; i < noun.Count; i++)
            {
                int el1 = rand.Next(1, noun.Count);
                string word1 = noun[el1];
                noun.RemoveAt(el1);

                int el2 = rand.Next(1, verb.Count);
                string word2 = verb[el2];
                verb.RemoveAt(el2);

                Console.WriteLine($"{word1}, {word2}");
            }

            Console.WriteLine("\n-----------\n");

            //Задание 3: Текстовый квест
            Console.WriteLine("Вы просыпаетесь в незнакомом месте. Вокруг темно, и вы" +
                " понимаете, что находитесь в каком-то подвале. На полу лежит тусклый фонарь," +
                " освещающий небольшой участок вокруг вас. Вам нужно выбраться отсюда.");

            Console.WriteLine("\nЧто будете делать?\nОсмотреться - 1\nПозвать на помощь - 2");

            string num = Console.ReadLine();

            if (num == "1")
            {
                Console.WriteLine("\nВы осматриваетесь вокруг и находите лестницу, ведущую наверх." +
                    " Рядом с ней висит ключ на стене. Возьмите ключ?");

                Console.WriteLine("\nВзять ключ - 1\nОставить ключ и подняться по лестнице - 2");
            }
            else if (num == "2")
            {
                Console.WriteLine("Злодей услышал ваш крик и убил!");
                Environment.Exit(0);
            }

            num = Console.ReadLine();

            if (num == "1")
            {
                Console.WriteLine("\nВы берёте ключ и поднимаетесь по лестнице. Дверь наверху заперта," +
                    " но ключ подходит. Вы открываете дверь и выходите наружу. Оказавшись снаружи, вы" +
                    " видите, что находитесь в старом заброшенном доме. Впереди два выхода: дверь в" +
                    " дом и разбитое окно.");
                Console.WriteLine("\nКуда пойдете?\nЧерез дверь в дом - 1\nЧерез разбитое окно - 2");
            }
            else if (num == "2")
            {
                Console.WriteLine("Вы попадаете в комнату маньяка и погибаете!");
                Environment.Exit(0);
            }

            num = Console.ReadLine();

            if (num == "1")
            {
                Console.WriteLine("\nВы долго ходите по тёмным лабиринтам дома. Маньяк вас находит и убивает!");
                Environment.Exit(0);
            }
            else if (num == "2")
            {
                Console.WriteLine("Вы выбираетесь наружу и убегаете. Квест выполнен!");
            }


            Console.WriteLine("\n-----------\n");
            //Задание 4: Симулятор магазина

            Console.WriteLine("Добро пожаловать в магазин! У вас на счету: 300 монет.");

            int money = 300;
            string[] good = { "Хлеб", "Молоко", "Сало", "Мясо", };

            Random price = new Random();
            while(money > 30)
            {
                int[] ints = { price.Next(30, 100), price.Next(30, 100), price.Next(30, 100), price.Next(30, 100) };
                
                Console.WriteLine($"\nВыберете товар.\nТовары в наличии: " +
                    $"\n1.Хлеб - {ints[0]} монет" +
                    $"\n2.Молоко - {ints[1]} монет" +
                    $"\n3.Сало - {ints[2]} монет" +
                    $"\n4.Мясо - {ints[3]} монет" +
                    $"\n0.Покинуть магазин");

                string choice = Console.ReadLine();

                int last_money = money;
                if (choice == "0") break;
                else if (choice == "1") money -= ints[0];
                else if (choice == "2") money -= ints[1];
                else if (choice == "3") money -= ints[2];
                else if (choice == "4") money -= ints[3];

                if (money < 0)
                {
                    Console.WriteLine($"Недостаточно денег! Остаток - {last_money}");
                    money = last_money;
                }
                else Console.WriteLine($"Остаток - {money}");


            }

        }

    }

}
