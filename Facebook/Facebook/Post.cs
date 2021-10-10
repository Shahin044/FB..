using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class Post
    {
        public string Text;
        public string SharedDate;
        public string LikeCount;
        public string CommentCount;
        public Comment[] Comment;

        public Post(string text)
        {
            this.Text = text;
        }
    }
}
