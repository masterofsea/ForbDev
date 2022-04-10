using System.Text;
using System.Text.RegularExpressions;
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
    
    private static object GetPropertyValue(object obj, string propertyName)
    {
        foreach (var t in propertyName.Split('.'))
        {
            var propertyInfo = obj.GetType().GetProperty(t); ;
            
            obj = propertyInfo?.GetValue(obj) ?? 
                  throw new ArgumentException("Argument with such name does not exist");
        }

        return obj;
    }

    public async Task<string> BuildMessage(string messageTemplateName, object messageData)
    {
        var template = await TemplatesRepository.GetTemplateByName(messageTemplateName);
        
        var regex = new Regex(@"(?<=\[).+?(?=\])");
        var fields = regex.Matches(template.Body); //TODO: добавить в конфиг

        var builder = new StringBuilder(template.Body);
        foreach (Match field in fields)
            builder.Replace($"[{field.Value}]", GetPropertyValue(messageData, field.Value).ToString());
        
        return builder.ToString();
    }
}