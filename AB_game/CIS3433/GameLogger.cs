using System;
using System.Data.SqlClient;
using System.IO;

namespace CIS3433
{
    public class GameLogger
    {
        private string connectionString; // Connection string for the local database

        public GameLogger()
        {
            // Get the path to the database file within the project directory
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ABGameDatabase.mdf");

            // Set the connection string using the database file path
            connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\FANGPROJ\AB_game\MSSQLLocalDB;Integrated Security=True";
        }

        public void LogGameInfo(string playerName, string gameMode, DateTime playDate, int totalTries, int totalSeconds, string secretNumber, string[] guesses, string[] hints, int gameScore)
        {
            // Prepare the SQL query to insert game information into the database
            string query = @"INSERT INTO GameLogs (PlayerName, GameMode, PlayDate, TotalTries, TotalSeconds, SecretNumber, Guesses, Hints, GameScore)
                             VALUES (@PlayerName, @GameMode, @PlayDate, @TotalTries, @TotalSeconds, @SecretNumber, @Guesses, @Hints, @GameScore)";

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                // Create a new SqlCommand with the SQL query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.Parameters.AddWithValue("@GameMode", gameMode);
                    command.Parameters.AddWithValue("@PlayDate", playDate);
                    command.Parameters.AddWithValue("@TotalTries", totalTries);
                    command.Parameters.AddWithValue("@TotalSeconds", totalSeconds);
                    command.Parameters.AddWithValue("@SecretNumber", secretNumber);
                    command.Parameters.AddWithValue("@Guesses", string.Join(",", guesses));
                    command.Parameters.AddWithValue("@Hints", string.Join(",", hints));
                    command.Parameters.AddWithValue("@GameScore", gameScore);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
