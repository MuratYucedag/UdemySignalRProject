using SignalR.EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
	{
		void BookingStatusApproved(int id);
		void BookingStatusCancelled(int id);
	}
}
