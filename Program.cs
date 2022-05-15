using System;

namespace First_Task
{
    class First_Task
    {
        public static int Main()
        {

            //=============Events=============
            Console.WriteLine("������� ����������� ���������� ����� ��� �����������:");
            int countOfMembers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ���������� �����, ������� ������:");
            int countOfMembersCollected = Convert.ToInt32(Console.ReadLine());

            Events evnt = new Events(countOfMembers, countOfMembersCollected);
            int check = evnt.CountOfMembers;

            if (evnt.Verify)
            {
                Console.WriteLine("\n����������� ����� ���������!");
            }
            else { Console.WriteLine("\n����������� ����� �� ����������, �.�. ��� ������������ ���������� �������"); }

            Console.WriteLine("\n������� �����������:");
            evnt.Description = Console.ReadLine();
            string desc = evnt.Description;
            Console.WriteLine("�������� �����������:");
            Console.WriteLine(desc);

            //=============Posts=============

            Console.WriteLine("����� �����:");
            string author = Console.ReadLine();

            Console.WriteLine("���������� �����:");
            string content = Console.ReadLine();

            Console.WriteLine("\n����� �����������:");
            string author1 = Console.ReadLine();

            Console.WriteLine("�����������:");
            string content1 = Console.ReadLine();
            
            Posts post = new Posts(author, content);

            Console.WriteLine("\n������� ���� ����� ��� ������ ���� ������������ ����������� ����. ������� ���: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ���� ����� ��� ������ ���� ������������ ����������� ����. ������� �����: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ���� ����� ��� ������ ���� ������������ ����������� ����. ������� ����: ");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            Console.WriteLine("������� ���� ����� ��� ������ ���� ������������ ����������� ����:");
            Console.WriteLine(post.GetTimeFromDay(date));

            Console.WriteLine("���� �������� �����:");
            Console.WriteLine(post.GetLifeTime());


            //=============Comments=============

            Comments comment = new Comments(author, content);

            comment.Content = content1;
            string someString = comment.Content;

            Console.WriteLine("������� ���� ����� ��� �������� �����������:");
            Console.WriteLine(comment.GetLifeTime());

            return 0;
        }

    }
}