using System;
using System.Collections.Generic;

#nullable disable

namespace spmedical_API.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consultum>();
            Especialidades = new HashSet<Especialidade>();
        }

        public int IdMedico { get; set; }
        public int IdUsuario { get; set; }
        public short IdClinica { get; set; }
        public string Crmv { get; set; }

        public virtual ClinicaSp IdClinicaNavigation { get; set; }
        public virtual UsuarioSp IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
        public virtual ICollection<Especialidade> Especialidades { get; set; }
    }
}
