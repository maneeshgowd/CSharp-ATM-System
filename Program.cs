using ATM_System.Services;

Machine machine = new(new Greetings());

try
{
    machine.PerformOperation();
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n {ex.GetType().Name}: {ex.Message}");
    Console.ForegroundColor = ConsoleColor.White;
}
