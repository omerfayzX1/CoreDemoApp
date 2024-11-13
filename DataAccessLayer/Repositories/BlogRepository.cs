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
            context.Add(blog);
            context.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            context.Remove(blog);
            context.SaveChanges();
        }

        public Blog GetById(int id)
        {
          return context.
        }

        public void UpdateBlog(Blog blog)
        {
            context.Update(blog);
            context.SaveChanges();
        }
    }
}
