using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace spmedical_API.Domains
{
    public partial class UsuarioSp
    {
        public UsuarioSp()
        {
            Medicos = new HashSet<Medico>();
            Pacientes = new HashSet<Paciente>();
        }

        public int IdUsuario { get; set; }
        public short IdTipoUsuario { get; set; }
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha invalida!")]
        [StringLength(20, MinimumLength = 5, ErrorMessage ="A Senha deve ter entre 5 e 20 caracteres")]
        public string Senha { get; set; }

        public virtual TipoUsuarioSp IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
