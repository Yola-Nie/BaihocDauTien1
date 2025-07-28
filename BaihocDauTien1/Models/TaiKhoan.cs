using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaihocDauTien1.Models
{
    [Table ("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        public int Id { get; set; }
        public string TenDangNhap { get; set; }
        public string safalfa;
        public string MatKhau { get; set; }
    }
}