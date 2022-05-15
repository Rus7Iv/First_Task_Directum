using System;
using System.Collections.Generic;
using System.Text;

namespace First_Task
{
    public class Comments
    {
        public DateTime CreationDate; // ���� �������� �����������

        private string author;        // �����
        private string content;       // ���������� �����

        public Comments(string Author, string Content)
        {
            author = Author;
            CreationDate = DateTime.Now.Date;
            content = Content;
        }
        public string Content
        {
            get => content;
            set
            {
                content = value;
            }
        }

        public TimeSpan GetLifeTime()
            => DateTime.Now.Date - CreationDate; // ������� ���� ����� ��� ������ �����������
    }
}