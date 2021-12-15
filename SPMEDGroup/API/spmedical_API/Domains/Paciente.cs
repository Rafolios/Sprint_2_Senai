﻿using System;
using System.Collections.Generic;

#nullable disable

namespace spmedical_API.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdPaciente { get; set; }
        public int IdUsuario { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public string Endereco { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public virtual UsuarioSp IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
