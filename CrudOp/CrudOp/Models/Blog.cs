using System;
using System.Collections.Generic;
using System.Text;

namespace CrudOp.Models
{
    class Blog
    {
        public int Id { get; set; }
        public string URL { get; set; }

        public List<Post> Post { get; set; }
    }
    class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int IdBlog { get; set; }

        public Blog blog { get; set; }
    }
}
