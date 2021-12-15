using System;
using System.Collections.Generic;

#nullable disable

namespace spmedical_API.Domains
{
    public partial class Consultum
    {
        public int IdConsulta { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
        public byte IdDiagnostico { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Descricao { get; set; }

        public virtual DiagnosticoSp IdDiagnosticoNavigation { get; set; }
        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
