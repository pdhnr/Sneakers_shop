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


        //Nazwisko Administratora
        [Required]
        [StringLength(50)]
        public string Ad_Surename { get; set; }


        //Hasło Administratora
        [Required]
        public string Ad_Password { get; set; }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Związek z Category (Jeden do Wielu)//

        public ICollection<Category_Model> category_Models { get; set; } //Związek z Category (Jeden do Wielu)

    }
}
