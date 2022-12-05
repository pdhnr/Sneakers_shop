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
            DbPath = System.IO.Path.Join(path, "Sneakers_shop.db");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder
        options)
        => options.UseSqlite($"Data Source={DbPath}");


        //////////////////////////////////////////////////////////////////////////////////////////////////
        //Encji//

        public DbSet<Admin_Model> admin_Models { get; set; }
        
        public DbSet<Category_Model> category_Models { get; set; }  

        public DbSet<User_Model> user_Models { get; set; }  

        public DbSet<ProdukcjaButow_Model> produkcjaButow_Models { get; set; }




        //////////////////////////////////////////////////////////////////////////////////////////////
        //Tworzenie Fluent API 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            ///////////////////////////////////////////////////////////////////////
            //Jeden-do-Wielu (Admin(j.) - Kategorii(m.))

            modelBuilder.Entity<Category_Model>()
            .HasOne<Admin_Model> (eA => eA.Admin_Model)
            .WithMany(eC => eC.category_Models)
            .IsRequired();



            ///////////////////////////////////////////////////////////////////////
            //Jeden-do-Wielu (Kategoria(j.) - Produkcja(m.))
            modelBuilder.Entity<ProdukcjaButow_Model>()
            .HasOne<Category_Model>(eC => eC.Category_Model)
            .WithMany(eP => eP.produkcjaButow_Models)
            .IsRequired();



            ///////////////////////////////////////////////////////////////////////
            //Jeden-do-Wielu (Urzytkownik(j.) - Produkcja(m.))
            modelBuilder.Entity<ProdukcjaButow_Model>()
            .HasOne<User_Model>(eU => eU.User_Model)
            .WithMany(eP => eP.produkcjaButow_Models)
            .IsRequired();



            //////////////////////////////////////////////////////////////////////
            //Wartość - Encji(tabeli) Admin

            modelBuilder.Entity<Admin_Model>().HasData(
           new Admin_Model() { Ad_Id = 1, Ad_Surename = "root", Ad_Password = "admin123" },
           new Admin_Model() { Ad_Id = 2, Ad_Surename = "admin", Ad_Password = "admin123" },
           new Admin_Model() { Ad_Id = 3, Ad_Surename = "test", Ad_Password = "admin123" }
            );

        }





    }
}
