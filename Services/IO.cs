using System.Text;
using System.Text.Json;
using Models;

namespace ATM_System.Services
{
    public static class FileSystem
    {
        public static List<Account> ReadFileAsync()
        {
            var file = File.ReadAllTextAsync(@"C:\Users\manee\Projects\C#\ATM-System\AccountsData.json")
            .GetAwaiter().GetResult();

            var accounts = JsonSerializer.Deserialize<List<Account>>(file);

            return accounts;
        }

        public static void WriteFileAsync(List<Account> accountData)
        {
            var file = JsonSerializer.Serialize(accountData);

            File.WriteAllTextAsync(@"C:\Users\manee\Projects\C#\ATM-System\AccountsData.json", file, Encoding.UTF8);
        }
    }
}