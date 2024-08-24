using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class Order
    {
		public int OrderID { get; set; }
		public ICollection<CartLine>? Lines { get; set; }
        [Required(ErrorMessage = "Введите Ваше имя")]
		public string Name { get; set; }
        [Required(ErrorMessage = "Введите улицу")]
        public string Street  { get; set; }
        [Required(ErrorMessage = "Введите город")]
        public string City { get; set; }
        [Required(ErrorMessage = "Введите индекс")]
        public string ZipCode { get; set; }
        //[RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Введите телефон в формате +7-ххх-ххх-хх-хх")]
        //[Required]
        [RegularExpression(@"(\+7|8|\b)[\(\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[)\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)", ErrorMessage = "Введите телефон в формате +7-ххх-ххх-хх-хх")]
        public string Phone { get; set; }
        public bool GiftWrap { get; set; }
    }
}
