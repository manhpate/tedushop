using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Tự động tăng
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }


        //Khóa phụ GroupID nối với khóa chính trong bảng MenuGroup : 
        [Required]
        public int GroupID { get; set; }
        [ForeignKey("GroupID")] 
        public virtual MenuGroup MenuGroup { get; set; }


        [MaxLength(10)]
        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }

    }
}
