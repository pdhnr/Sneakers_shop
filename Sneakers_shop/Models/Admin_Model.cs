using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sneakers_shop.Models
{
    public class Admin_Model
    {

        //Klucz Glowny 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ad_Id { get; set; }



        //Urzytkownik Administrator

        //[Column("Username")] //Nie działa logowanie - jezeli wlącze nazwa kolumny "Username"!!!!???
        [Required]
        [StringLength(50)]
        public string Ad_Surename { get; set; } //Czemu kiedy ja zmeniam z Ad_Surename na Ad_Username - to nie działa ????



        //Hasło Administratora

        //[Column("Password")] 
        [Required]
        public string Ad_Password { get; set; }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Związek z Category (Jeden do Wielu)//

        public ICollection<Category_Model> category_Models { get; set; } //Związek z Category (Jeden do Wielu)

    }
}
