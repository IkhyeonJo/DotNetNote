﻿using System.Threading.Tasks;

namespace DotNetNoteCore.Services
{
    public interface IEmailManager
    {
        Task SendEmailAsync(string email, string subject, string message, string recipient = "", string callbackUrl = "");

        Task SendEmailCodeAsync(string email, string subject, string message, string recipient = "", string callbackUrl = "");
    }
}