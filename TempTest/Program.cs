using ForbexBAL.MailBox.MessageBuilding.Implementations;
using ForbexDAL.Data;
using ForbexDAL.Repositories.Implementations;

class Program
{
    static async Task Main()
    {
        var messageBuilder = new MessageBuilder(new FileSystemTemplateRepository());
        var data = new Contract
        {
            Address = "Улица Пушкина дом Колотушкина",
            LeaseStartDate = DateTime.Parse("21.10.2018"),
            LeaseEndDate = DateTime.Parse("13.10.2020"),
            Ifts = "11111111111111"
            
        };
        var message = await messageBuilder.BuildMessage("Детализация адреса", data);
        Console.WriteLine(message);
    }
}