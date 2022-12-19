using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sneakers_shop.Models
{
    [Table("Produkcja butów")]
    public class ProdukcjaButow_Model
    {
        //Klucz Glowny 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Prod_Id { get; set; }


        //Marka Butów
        [Column("Marka butów")]
        [Required(ErrorMessage = "Proszę podać nazwe marke butów, w punkcie \"Marka butów\"!")]
        //[StringLength(50)]
        [MaxLength(50, ErrorMessage = "Zadługi tekst! W formularze, może wmieścić się do 50 symbolów.")]
        [MinLength(0, ErrorMessage = "Zakrutki tekst! Musisz wpisać nazwe marke butów.")]
        public string Prod_Marka { get; set; }


        //Model Butów
        [Column("Model butów")]
        [Required(ErrorMessage = "Proszę podać nazwe modele butów, w punkcie \"Model butów\"!")]
        //[StringLength(50)]
        [MaxLength(50, ErrorMessage = "Zadługi tekst! W formularze, może wmieścić się do 50 symbolów.")]
        [MinLength(0, ErrorMessage = "Zakrutki tekst! Musisz wpisać nazwe modele butów.")]
        public string Prod_Model { get; set; }


        //Rodzaj Butów
        [Column("Rodzaj butów")]
        [Required] 
        public Erodzaj Prod_Rodzaj { get; set; }


        //Kolor Butów
        [Column("Kolor butów")]
        [Required]
        public Ekolor Prod_Kolor { get; set; }



        //Cena Butów
        [Column("Cena butów")]
        [Required(ErrorMessage = "Proszę podać cenę butów, w punkcie \"Cena butów\"!")]
        [Range(0,1000000, ErrorMessage = "Proszę podać cenę butów, 0 - 1 000 000. W formularze \"Cena butów\"!")]
        public double Prod_Cena { get; set; }


        
        //Photo Butów
        /*
        [Column("Zdjęcie butów")]
        [Required(ErrorMessage = "Proszę przypnić zdjęcie, w formularze \"Zdjęcie butów\"!")]
        public string Prod_Image { get; set; }
        */


    }



    //*************************************************************************************************//
    //Enum: Rodzaj butów i Kolor butów//

    public enum Erodzaj
    {
        [Display(Name = "Klasyczne")] Klasyczne,
        //Klasyczne,


        [Display(Name = "Triningowe")] Treningowe,
        //Treningowe,

        [Display(Name = "Zimowe")] Zimowe,
        //Zimowe,

        //[Display(Name = "Klapki")] Klapki
        //Klapki
    }




    public enum Ekolor
    {
        [Display(Name = "Białe")] Białe,
        //Białe,

        [Display(Name = "Czarne")] Czarne,
        //Czarne,

        [Display(Name = "Szare")] Szare,
        //Szare,

        [Display(Name = "Czerwone")] Czerwone,
        //Czerwone,

        [Display(Name = "Niebieski")] Niebieski,
        //Niebieski,

        [Display(Name = "Żółty")] Żółty
        //Żółty

    }

}
