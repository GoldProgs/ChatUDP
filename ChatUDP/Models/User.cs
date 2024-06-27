using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ChatUDP.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
#pragma warning disable CS8618 
        [NotNull]
        [MinLength(5, ErrorMessage = "Минимальная длина ФИО должна составлять 5 символов.")]
        [MaxLength(160, ErrorMessage = "Максимальная длина ФИО должна составлять 160 символов.")]
        public string FullName { get; set; }

        [NotNull]
        [MinLength(8, ErrorMessage = "Пароль должен содержать минимум 8 символов.")]
        [MaxLength(128, ErrorMessage = "Максимальная длина пароля должна составлять 128 символов.")]
        public string Password { get; set; }

        [NotNull]
        [MaxLength(256, ErrorMessage = "Максимальная длина электронной почты должна составлять 256 символов.")]
        [EmailAddress(ErrorMessage = "Некорректно введённый адрес электронной почты или его формат.")]
        public string Email { get; set; }

        [NotNull]
        public DateTime Birthday { get; set; }

#pragma warning restore CS8618
    }
}
