namespace ForbexBAL.MailBox.MessageBuilding.Contracts;

public interface IMessageBuilder
{
    Task<string> BuildMessage(string messageTemplateName, object messageData);
}