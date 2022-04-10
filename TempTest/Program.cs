using System.Text;
using ForbexBAL.MailBox.MessageBuilding.Implementations;
using ForbexDAL.Data;
using ForbexDAL.Repositories.Implementations;

namespace TempTest;

internal static class Program
{
    private static async Task Main()
    {
        var messageBuilder = new MessageBuilder(new FileSystemTemplateRepository());
        var data = new Contract
        {
            Address = "Улица Пушкина дом Колотушкина",
            LeaseStartDate = DateTime.Parse("21.10.2018"),
            LeaseEndDate = DateTime.Parse("13.10.2020"),
            Ifts = "11111111111111",
            Lessee = new Lessee
            {
                ShortName = "Хуйня ёбаная",
                OrganizationLegalFormShort = OrganizationLegalFormShort.OAO
            }
        };
        var message = await messageBuilder.BuildMessage("Детализация адреса", data);
        Console.WriteLine(message);

        // var path = @"C:\Users\Артона\Downloads\Шаблоны";
        // foreach (var file in Directory.GetFiles(path))
        // {
        //     //Считываем данные
        //     StringBuilder templateContentBuilder;
        //     using (var reader = new StreamReader(file))
        //     {
        //         templateContentBuilder = new StringBuilder(await reader.ReadToEndAsync());
        //     }
        //     
        //     
        //     //Модифицируем данные
        //     templateContentBuilder = templateContentBuilder.Replace("Contract.", "");
        //     
        //
        //     //Записываем измененные данные
        //     await using (var sw = new StreamWriter(file, false))
        //     {
        //         await sw.WriteAsync(templateContentBuilder.ToString());
        //     }
        // }
        
    }
}