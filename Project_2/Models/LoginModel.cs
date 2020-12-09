using System.ComponentModel.DataAnnotations;

namespace Project_2.Models
{
    public class LoginModel
    {
        
            [Required(ErrorMessage = "Не указан Email")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Не указано ваше имя пользоваля")]
            [DataType(DataType.Text)]
            public string UserName { get; set; }

            [Required(ErrorMessage = "Не указан пароль")]
            [DataType(DataType.Password)]       
            public string Password { get; set; }

            [Display(Name = "Запомнить?")] // добавляем с етой строчки
            public bool RememberMe { get; set; } 

            public string ReturnUrl { get; set; }


    }
}
