using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
	public class MessageManager : IMessageService
	{
		private readonly IMessageDal _messageDal;
		public MessageManager(IMessageDal messageDal)
		{
			_messageDal = messageDal;
		}
		public void TAdd(Message entity)
		{
			_messageDal.Add(entity);
		}

		public void TDelete(Message entity)
		{
			_messageDal.Delete(entity);
		}

		public Message TGetByID(int id)
		{
			return _messageDal.GetByID(id);
		}

		public List<Message> TGetListAll()
		{
			return _messageDal.GetListAll();
		}

		public void TUpdate(Message entity)
		{
			_messageDal.Update(entity);
		}
	}
}
