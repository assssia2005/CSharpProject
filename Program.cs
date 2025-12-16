namespace CSharpProject;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Database.InitializeDatabase();
        if (File.Exists("Food_Nutrition_Dataset.csv") && Database.IsDatabaseEmpty())
        {
            Database.ImportDataFromCsv("Food_Nutrition_Dataset.csv");
        }
        Application.Run(new Form1());
    }    
}