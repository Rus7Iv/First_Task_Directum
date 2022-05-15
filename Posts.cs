using System;
using System.Collections.Generic;
using System.Text;

namespace First_Task
{
    public class Posts
    {
        public DateTime CreationDate; // дата создания поста
        public string Author;         // автор поста

        private string content;       // содержимое поста
        private string previewContent;// превью поста

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
            => DateTime.Now.Date - CreationDate; // сколько дней назад был создан пост
        public TimeSpan GetTimeFromDay(DateTime date)
            => date.Date - CreationDate; // сколько дней назад был создан пост относительно определённой даты
    }
}
