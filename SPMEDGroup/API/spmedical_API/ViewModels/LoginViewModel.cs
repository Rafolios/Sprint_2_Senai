using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage ="Email incorreto!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha inválida!")]
        public string Senha { get; set; }

    }
}
