using ForbexBAL.MailBox.MessageBuilding.Implementations;
using ForbexDAL.Repositories.Implementations;

class Program
{
    static async Task Main()
    {
        var messageBuilder = new MessageBuilder(new FileSystemTemplateRepository());
        var message = await messageBuilder.BuildMessage("Детализация адреса", "Улица Пушкина дом Колотушкина");
        Console.WriteLine(message);
    }
}