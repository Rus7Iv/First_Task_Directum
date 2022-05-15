using System;

namespace First_Task
{
    class First_Task
    {
        public static int Main()
        {

            //=============Events=============
            Console.WriteLine("Введите необходимое количество людей для мероприятия:");
            int countOfMembers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество людей, готовых прийти:");
            int countOfMembersCollected = Convert.ToInt32(Console.ReadLine());

            Events evnt = new Events(countOfMembers, countOfMembersCollected);
            int check = evnt.CountOfMembers;

            if (evnt.Verify)
            {
                Console.WriteLine("\nМероприятие точно состоится!");
            }
            else { Console.WriteLine("\nМероприятие может НЕ состояться, т.к. нет необходимого количества человек"); }

            Console.WriteLine("\nОпишите мероприятие:");
            evnt.Description = Console.ReadLine();
            string desc = evnt.Description;
            Console.WriteLine("Описание мероприятия:");
            Console.WriteLine(desc);

            //=============Posts=============

            Console.WriteLine("Автор поста:");
            string author = Console.ReadLine();

            Console.WriteLine("Содержимое поста:");
            string content = Console.ReadLine();

            Console.WriteLine("\nАвтор комментария:");
            string author1 = Console.ReadLine();

            Console.WriteLine("Комментарий:");
            string content1 = Console.ReadLine();
            
            Posts post = new Posts(author, content);

            Console.WriteLine("\nСколько дней назад был создан пост относительно определённой даты. Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько дней назад был создан пост относительно определённой даты. Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько дней назад был создан пост относительно определённой даты. Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            Console.WriteLine("Сколько дней назад был создан пост относительно определённой даты:");
            Console.WriteLine(post.GetTimeFromDay(date));

            Console.WriteLine("Дата создания поста:");
            Console.WriteLine(post.GetLifeTime());


            //=============Comments=============

            Comments comment = new Comments(author, content);

            comment.Content = content1;
            string someString = comment.Content;

            Console.WriteLine("Сколько дней назад был оставлен комментарий:");
            Console.WriteLine(comment.GetLifeTime());

            return 0;
        }

    }
}