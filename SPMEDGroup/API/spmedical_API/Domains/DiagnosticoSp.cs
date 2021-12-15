using System;
using System.Collections.Generic;

#nullable disable

namespace spmedical_API.Domains
{
    public partial class DiagnosticoSp
    {
        public DiagnosticoSp()
        {
            Consulta = new HashSet<Consultum>();
        }

        public byte IdDiagnostico { get; set; }
        public string Diagnostico { get; set; }

        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
