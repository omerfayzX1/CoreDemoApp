using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CommentManager : ICommentService
    {
        ICommentDal dal;

        public CommentManager(ICommentDal dal)
        {
            this.dal = dal;
        }

        public void CommentAdd(Comment comment)
        {
            dal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
           return dal.GetListAll(x => x.BlogId == 1);
        }

      
    }
}
