using Microsoft.Data.Sqlite;

namespace didntreally.HabitTracker;
class Program
{
    static void Main(string[] args)
    {
        string connectionString = @"Data Source=habit-Tracker.db";

        using var connection = new SqliteConnection(connectionString);
        connection.Open();
        var tableCmd = connection.CreateCommand();
        tableCmd.CommandText =
            @"CREATE TABLE IF NOT EXISTS drinking_water (
                     Id INTEGER PRIMARY KEY AUTOINCREMENT,
                     Date TEXT,
                     Quantity INTEGER
                     )";
        tableCmd.ExecuteNonQuery();
        connection.Close();

        GetUserInput();
    }

    static void GetUserInput()
    {
        Console.Clear();
        bool closeApp = false;
        while (closeApp == false)
        {
            Console.WriteLine("\n\nWELCOME TO HABIT TRACKER!");
            Console.WriteLine("\nPlease choose an option!");
            Console.WriteLine("Type 1 to View All records");
            Console.WriteLine("Type 2 to Insert record");
            Console.WriteLine("Type 3 to Delete record");
            Console.WriteLine("Type 4 to Update record");
            Console.WriteLine("______________________________________\n");

            string userString = Console.ReadLine();
            int userInt;
            while (!int.TryParse(userString, out userInt))
            {
                Console.WriteLine("Please enter a valid number!");
                userString = Console.ReadLine();
            }
        }

    }
}

