using System.ComponentModel.DataAnnotations;

namespace MegaDesk_2._0.Models
{
    public class Desk
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string? name { get; set; } = string.Empty;
        [Display(Name = "Drawers")]
        public int? drawers { get; set; }
        [Display(Name = "Material")]
        public string? material { get; set; } = string.Empty;
        [Display(Name = "Price")]
        public float? price { get; set; }
        [Display(Name = "Height")]
        public int? height { get; set; }
        [Display(Name = "Width")]
        public int? width { get; set; }
        [Display(Name = "Rush Order ")]
        public int rushOrder { get; set; }
    }
}
