﻿using System.Threading.Tasks;

namespace CfpExchange.Services
{
	public interface IEmailSender
	{
		Task SendEmailAsync(string emailAddress, string subject, string body);
		Task SendEmailAsync(string emailAddress, string from, string subject, string body);
	}
}