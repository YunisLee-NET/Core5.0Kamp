using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Comment GetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public List<Comment> TGetList(int id)
        {
            return _commentDal.GetListAll(x => x.BlogID == id);
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
