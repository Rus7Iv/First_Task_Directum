using System;
using System.Collections.Generic;
using System.Text;

namespace First_Task
{
    public class Posts
    {
        public DateTime CreationDate; // ���� �������� �����
        public string Author;         // ����� �����

        private string content;       // ���������� �����
        private string previewContent;// ������ �����

        public List<Comments> Comments;

        public Posts(string author, string content)
        {
            CreationDate = DateTime.Now.Date;

            Author = author;
            Content = content;
        }

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

        public string PreviewContent
        {
            get
            {
                return previewContent;
            }
            set
            {
                previewContent = value;
            }
        }

        public TimeSpan GetLifeTime()
            => DateTime.Now.Date - CreationDate; // ������� ���� ����� ��� ������ ����
        public TimeSpan GetTimeFromDay(DateTime date)
            => date.Date - CreationDate; // ������� ���� ����� ��� ������ ���� ������������ ����������� ����
    }
}
