using Coffee_Machine_MenuDisplay;
using Coffee_Machine_MenuDisplay.Contracts;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddScoped<IMenuDisplayService, MenuDisplayService>()
        .BuildServiceProvider();

        var menuDisplayService = serviceProvider.GetService<IMenuDisplayService>();
        if (menuDisplayService == null)
        {
            Console.WriteLine("The machine can't start. Please call the HelpDesk.");
        }
        else
        {
            while(true)
            {
                Console.WriteLine("Choose your drink or type quit to shutdown the machine");

                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    if (readLine.Equals("quit", StringComparison.InvariantCultureIgnoreCase))
                    {
                        break;
                    }
                    try
                    {
                        var price = menuDisplayService.GetPrice(readLine);
                        Console.WriteLine(price);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}