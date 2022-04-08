using System.Text;
using System.Text.RegularExpressions;
using ForbexBAL.MailBox.MailSending.MessageBuilding.Contracts;
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
        var filepath = @"C:\Users\Артона\Downloads\Шаблоны\Детализация адреса.txt";
        //var builder = new StringBuilder(await TemplatesRepository.GetTemplateByName(messageTemplateName));
        
        string template;
        using (var sr = new StreamReader(filepath)) template = await sr.ReadToEndAsync();
        
        var builder = new StringBuilder(template);
        var rgx = new Regex(@"\[[A-Za-z]+.[A-Za-z]+\]");
        
        var fields = rgx.Matches(template);

        foreach (var field in fields)
        {
            Console.WriteLine((string)field);
        }
        //Здесь нужно написать алгоритм приведения шаблона к письму
        
        return builder.ToString();
    }
}