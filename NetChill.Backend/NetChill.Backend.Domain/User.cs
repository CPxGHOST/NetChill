using System;
using System.ComponentModel.DataAnnotations;
using NetChill.Server.Domain.Enums;

namespace NetChill.Server.Domain
{
   public class User
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "FullName is Required!")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Email is Required!")]
        public string Email { get; set; }

        [Required, MinLength(8, ErrorMessage = "The minimum length of your password must be 8!")]
        public string Password { get; set; }

        [Required]
        public UserType Role { get; set; }
    }
}
