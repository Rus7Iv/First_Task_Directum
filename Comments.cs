using System;
using System.Collections.Generic;
using System.Text;

namespace First_Task
{
    public class Comments
    {
        public DateTime CreationDate; // дата создания комментария

        private string author;        // автор
        private string content;       // содержимое поста

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
            => DateTime.Now.Date - CreationDate; // сколько дней назад был создан комментарий
    }
}