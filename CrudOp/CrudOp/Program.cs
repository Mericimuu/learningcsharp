using CrudOp.Models;
using System;
using System.Linq;

namespace CrudOp
{
    class Program
    {
        static void Main(string[] args)
        {
            // addBlog();
            //updateBlog();
            //getBlog();
            getRemove();
            //Console.WriteLine("Hello World!");

            Console.ReadLine();
        }

        //create operation
        static void addBlog()
        {
            using (var blog = new BlogContext())
            {
                Blog b = new Blog() { URL = "TestURL" };
                blog.Blogs.Add(b);
                blog.SaveChanges();
            }
        }

        //update operation
        static void updateBlog()
        {
            using (var blog = new BlogContext())
            {
                Blog b = new Blog() { Id=1,URL = "New test URL" };
                blog.Blogs.Update(b);
                blog.SaveChanges();
            }
        }
        //read operation
        static void getBlog()
        {
            using (var blog = new BlogContext())
            {
                 
                foreach (var item in blog.Blogs.ToList())
                {
                    Console.WriteLine($"Id {item.Id} and URL {item.URL}");
                }
            }
        }

        //delete operation
        static void getRemove()
        {
            using (var blog = new BlogContext())
            {
                Blog b = new Blog() { Id = 1 };
                blog.Blogs.Remove(b);
                blog.SaveChanges();
                
            }
        }

    }
}
