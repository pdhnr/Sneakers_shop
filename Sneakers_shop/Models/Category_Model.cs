using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sneakers_shop.Models
{
    public class Category_Model
    {
        //Klucz Glowny 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Catg_Id { get; set; }

        //Nazwa Kategorji
        [Required]
        public string Catg_Name { get; set; }



        //////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        //(Klucz obcy)

        //FK_Admin   
        [ForeignKey("Admin_Model")]
       public int Admin_FK_Id { get; set; }       
       public Admin_Model Admin_Model { get; set; } //Związek z Admin_Model (Jeden do Wielu)



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Związek z Produkcja Butow (Jeden do Wielu)//
        public ICollection<ProdukcjaButow_Model> produkcjaButow_Models { get; set; } //Związek z ProdukcjaButow (Jeden do Wielu)
    }
}
