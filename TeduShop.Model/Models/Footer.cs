using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]//gọi tên bảng này là Footers
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]//bắt buộc người dùng nhập
        public string Content { get; set; }
    }
}