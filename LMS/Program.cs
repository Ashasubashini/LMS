using Final;
using MongoDB.Driver;
using MongoDB.Bson;
using LMS.GUIForms;


namespace LMS
{
    internal static class Program
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
            Application.Run(new LoginInterface());

            //Librarian librarian = new Librarian("admin", "admin", "admin", "admin");
            //var client = new MongoClient().GetDatabase("LMSdb");
            //client.GetCollection<Librarian>("Librariandb").InsertOne(librarian);

            //Console.WriteLine("kef");
            //Console.ReadLine();
        }
    }
}