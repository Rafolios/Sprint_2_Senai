using System;
using System.Collections.Generic;

#nullable disable

namespace spmedical_API.Domains
{
    public partial class ClinicaSp
    {
        public ClinicaSp()
        {
            Medicos = new HashSet<Medico>();
        }

        public short IdClinica { get; set; }
        public string NomeClinica { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Cnpj { get; set; }
        public TimeSpan HoraFuncional { get; set; }
        public TimeSpan HoraFechamento { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
