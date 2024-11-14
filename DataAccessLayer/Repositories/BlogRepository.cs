using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context context = new Context();
        public void AddBlog(Blog blog)
        {
            using var c = new Context();    
            context.Add(blog);
            context.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            using var c = new Context();
            context.Remove(blog);
            context.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return context.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return context.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {

            using var c = new Context();
            context.Update(blog);
            context.SaveChanges();
        }
    }
}
