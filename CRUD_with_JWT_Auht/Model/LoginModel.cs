using System.ComponentModel.DataAnnotations;

namespace CRUD_with_JWT_Auht.Model
{
    public class LoginModel
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
