using System;
using System.Collections.Generic;
using System.Text;

namespace _24_post_com_lista_de_comentarios.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new();
        public Post()
        { }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComent(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComent(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
