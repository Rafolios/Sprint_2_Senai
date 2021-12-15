using System;
using System.Collections.Generic;

#nullable disable

namespace spmedical_API.Domains
{
    public partial class Especialidade
    {
        public int IdEspecialidades { get; set; }
        public int IdMedico { get; set; }
        public string NomeEspecial { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
    }
}
