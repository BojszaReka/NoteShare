﻿using System.ComponentModel.DataAnnotations;

namespace NoteShare.Models.Auth
{
    public class LoginDto
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "A jelszónak hosszabbnak kell lennie, mint {2} és rövidebbnek, mint {1} karakter", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
