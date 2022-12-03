using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sneakers_shop.Models
{
    public class User_Model
    {
        //Klucz Glowny 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int U_Id { get; set; }


        //Imie Urzytkownika
        [Required]
        [StringLength(50)]
        public string U_Name { get; set; }


        //Email Urzytkownika
        [Required]
        [StringLength(50)]
        public string U_Email { get; set; }


        //Hasło Urzytkownika
        [Required]
        [StringLength(50)]
        public string U_Password { get; set; }


        //public string U_Image { get; set; }


        //Numer telefona Urzytkownika
        [Required]
        [StringLength(50)]
        public string U_Phone { get; set; }




        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Związek z Produkcja Butow (Jeden do Wielu)//

        public ICollection<ProdukcjaButow_Model> produkcjaButow_Models { get; set; } //Związek z Produkcja Butow (Jeden do Wielu)

    }
}
