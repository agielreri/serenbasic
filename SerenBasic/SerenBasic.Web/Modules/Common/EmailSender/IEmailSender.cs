using MimeKit;

namespace SerenBasic.Common
{
    public interface IEmailSender
    {
        void Send(MimeMessage message, bool skipQueue = false);
    }
}