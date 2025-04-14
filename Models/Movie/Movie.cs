using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace practice1.Models.Movie
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [StringLength(60,MinimumLength = 3, ErrorMessage ="電影名稱必須在3到60位元之間")]
        [Required(ErrorMessage ="請輸入電影名稱")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName ="Date")]
        [Required(ErrorMessage ="請選擇發行日期")]
        public DateTime ReleaseDate { get; set; }
        [Range(1,1000, ErrorMessage ="價格必須借於1到1000之間")]
        [Required(ErrorMessage ="請輸入價格")]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [Required(ErrorMessage ="請輸入電影類型")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""\s-]*$", ErrorMessage = "電影類型必須以大寫字母開頭，且只能包含字母、空格或連字符")]
        public string Gener { get; set; }
    }
}
