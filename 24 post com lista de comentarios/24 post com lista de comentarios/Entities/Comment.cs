using System;
using System.Collections.Generic;
using System.Text;

namespace _24_post_com_lista_de_comentarios.Entities
{
    class Comment
    {
        public string Text { get; set; }
        public Comment()
        {}
        public Comment(string text)
        {
            Text = text;
        }
    }
}
