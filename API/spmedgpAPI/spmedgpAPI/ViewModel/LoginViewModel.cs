using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O campo Email não pode ser vazio")]
        public string Email { get; set;}

        [Required(ErrorMessage = "O campo Senha nao pode ser vazio")]
        public string Senha { get; set;}

    }
}
