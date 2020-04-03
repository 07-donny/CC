using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Models.ContactModels
{
    public interface IEmailService
    {
        void Send(EmailMessage message);
    }
}
