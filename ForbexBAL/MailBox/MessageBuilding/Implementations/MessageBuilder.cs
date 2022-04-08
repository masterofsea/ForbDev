using System.Text;
using ForbexBAL.MailBox.MessageBuilding.Contracts;
using ForbexDAL.Repositories.Contracts;

namespace ForbexBAL.MailBox.MessageBuilding.Implementations;

public class MessageBuilder : IMessageBuilder
{
    private ITemplatesRepository TemplatesRepository { get; }
    
    public MessageBuilder(ITemplatesRepository templatesRepository)
    {
        TemplatesRepository = templatesRepository;
    }
    
    public async Task<string> BuildMessage(string messageTemplateName, object messageData)
    {
        var builder = new StringBuilder((await TemplatesRepository.GetTemplateByName(messageTemplateName)).Body);

        //Здесь нужно написать алгоритм приведения шаблона к письму
        
        return builder.ToString();
    }
}