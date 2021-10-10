using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Shahin", "Mammadli", "12.07.2003", "shahin@code.edu.az", true);
            User user2 = new User("İbrahim", "Ağayev", "04.11.2003", "ibiağa04@gmail.com", false);

            Post post1 = new Post("How are you");

            Comment comment1 = new Comment("Good,You");

            Post[] posts = { post1 };
            Comment[] comments = { comment1 };
            User[] commentedUser = { user2 };


            user1.Posts = posts;
        }
    }
}
