using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class Comment
    {
        public string Text;
        public string CommentedDate;

        public Comment(string text)
        {
            this.Text = text;
        }
    }
}
