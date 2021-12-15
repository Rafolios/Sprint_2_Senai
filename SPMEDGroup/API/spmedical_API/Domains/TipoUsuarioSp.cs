using System;
using System.Collections.Generic;

#nullable disable

namespace spmedical_API.Domains
{
    public partial class TipoUsuarioSp
    {
        public TipoUsuarioSp()
        {
            UsuarioSps = new HashSet<UsuarioSp>();
        }

        public short IdTipoUsuario { get; set; }
        public string NomeTipoUsuario { get; set; }

        public virtual ICollection<UsuarioSp> UsuarioSps { get; set; }
    }
}
