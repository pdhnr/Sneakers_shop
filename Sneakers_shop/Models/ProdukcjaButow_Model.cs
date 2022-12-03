using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sneakers_shop.Models
{
    public class ProdukcjaButow_Model
    {
        //Klucz Glowny 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Prod_Id { get; set; }


        //Marka Butów
        [Required]
        [StringLength(50)]
        public string Prod_Marka { get; set; }


        //Model Butów
        [Required]
        [StringLength(50)]
        public string Prod_Model { get; set; }


        //Rodzaj Butów
        [Required] 
        public Erodzaj Prod_Rodzaj { get; set; }


        //Kolor Butów
        [Required]
        public Ekolor Prod_Kolor { get; set; }



        //Cena Butów
        [Required]
        public double Prod_Cena { get; set; }



        //Photo Butów
        [Required]
        public string Prod_Image { get; set; }



        //////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        //Związki z Category i User  +  (Klucz obcy)


        //////////////////////////////////////////////////////////////////////////////////////////////

        //FK_Category   
        [ForeignKey("Category_Model")]
        public int Category_FK_Id { get; set; }
        public Category_Model Category_Model { get; set; } //Związek z Category_Model (Jeden do Wielu)



        ///////////////////////////////////////////////////////////////////////////////////////////////

        //FK_User   
        [ForeignKey("User_Model")]
        public int User_FK_Id { get; set; }
        public User_Model User_Model { get; set; } //Związek z User_Model (Jeden do Wielu)

    }

    //*************************************************************************************************//
    //Enum: Rodzaj butów i Kolor butów//

    public enum Erodzaj
    {
        //[Display(Name = "Klasyczne")] Klasyczne,
        Klasyczne,


        //[Display(Name = "Triningowe")] Treningowe,
        Treningowe,

        //[Display(Name = "Zimowe")] Zimowe,
        Zimowe,

        //[Display(Name = "Klapki")] Klapki
        Klapki
    }




    public enum Ekolor
    {
        //[Display(Name = "Białe")] Białe,
        Białe,

        //[Display(Name = "Czarne")] Czarne,
        Czarne,

        //[Display(Name = "Szare")] Szare,
        Szare,

        //[Display(Name = "Czerwone")] Czerwone,
        Czerwone,

        //[Display(Name = "Niebieski")] Niebieski,
        Niebieski,

        //[Display(Name = "Żółty")] Żółty
        Żółty

    }

}
