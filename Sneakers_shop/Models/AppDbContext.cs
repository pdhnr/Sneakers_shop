using Microsoft.EntityFrameworkCore;
namespace Sneakers_shop.Models

{
    public class AppDbContext : DbContext
    {
        public string DbPath { get; set; }
        public AppDbContext() //tutaj kawawek kodu nam robi w tem konstruktorze(AppDbContext()). Zapisuje nam automatycznie plik: C/(name_urzytkownik)/lokal.
                              //plik bedzie zapisany w iminu ("books.db"). i tam biedzie przechowywać naszą Baze danych(BD)
                              //zaby zapisać w ten plik w BD.
                              //Musimy: Narzędzia / Menadrzer NuGet / Konsole... / konsole ...  ,Musimy wpisać komende (update-database) 
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "SneakersShop.db");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder
        options)
        => options.UseSqlite($"Data Source={DbPath}");


        //////////////////////////////////////////////////////////////////////////////////////////////////
        //Encji//

        public DbSet<ProdukcjaButow_Model> produkcjaButow_Models { get; set; }




        //////////////////////////////////////////////////////////////////////////////////////////////
        //Tworzenie Fluent API 

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            
            modelBuilder.Entity<ProdukcjaButow_Model>().HasData(
           new ProdukcjaButow_Model() { Prod_Id = 1, Prod_Marka = "root", Prod_Model = "admin123" },
           new ProdukcjaButow_Model() { Prod_Id = 2, Prod_Marka = "admin", Prod_Model = "admin123" },
           new ProdukcjaButow_Model() { Prod_Id = 3, Prod_Marka = "test", Prod_Model = "admin123" }
            );
            

        }*/
        





    }
}
