using System.ComponentModel.DataAnnotations;

namespace wh3
{
    public enum ContactTypes
    {
        [Display(Name = "پیامک")]
        SMS = 1,
        [Display(Name = "ایمیل")]
        Email = 2
    }
}