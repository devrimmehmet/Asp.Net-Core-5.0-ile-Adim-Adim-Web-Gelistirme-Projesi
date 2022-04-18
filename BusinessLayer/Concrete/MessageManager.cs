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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
           _messageDal.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> GetList()
        {
            return _messageDal.GetList();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
