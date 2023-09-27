using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;
using SignalR.EntiyLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageController : ControllerBase
	{
		private readonly IMessageService _messageService;
		public MessageController(IMessageService messageService)
		{
			_messageService = messageService;
		}

		[HttpGet]
		public IActionResult MessageList()
		{
			var values = _messageService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMessage(CreateMessageDto createMessageDto)
		{
			Message message = new Message()
			{
				Mail = createMessageDto.Mail,
				MessageContent = createMessageDto.MessageContent,
				MessageSendDate = DateTime.Now,
				NameSurname = createMessageDto.NameSurname,
				Phone = createMessageDto.Phone,
				Status = false,
				Subject=createMessageDto.Subject
			};
			_messageService.TAdd(message);
			return Ok("Mesaj Başarılı Bir Şekilde Gönderildi");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteMessage(int id)
		{
			var value = _messageService.TGetByID(id);
			_messageService.TDelete(value);
			return Ok("Mesaj Silindi");
		}
		[HttpPut]
		public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
		{
			Message message = new Message()
			{
				Mail = updateMessageDto.Mail,
				MessageContent = updateMessageDto.MessageContent,
				MessageSendDate = updateMessageDto.MessageSendDate,
				NameSurname = updateMessageDto.NameSurname,
				Phone = updateMessageDto.Phone,
				Status = false,
				Subject = updateMessageDto.Subject,
				MessageID=updateMessageDto.MessageID
			};
			_messageService.TUpdate(message);
			return Ok("Mesaj Bilgisi Güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetMessage(int id)
		{
			var value = _messageService.TGetByID(id);
			return Ok(value);
		}
	}
}
