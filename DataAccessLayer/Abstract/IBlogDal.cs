using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        //CRUD İşlemleri
        #region
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void Delete(Blog blog);
        #endregion
        Blog GetById(int id);
    }
}
