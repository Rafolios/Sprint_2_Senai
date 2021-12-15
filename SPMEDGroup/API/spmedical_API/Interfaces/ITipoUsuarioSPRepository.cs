using spmedical_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Interfaces
{
    interface ITipoUsuarioSPRepository
    {
        List<TipoUsuarioSp> ListarTodos();
        TipoUsuarioSp BuscarPorId(int idTipoUsuario);
        void Cadastrar(TipoUsuarioSp novoTipoUsuario);
        void AtualizarIdCorpo(TipoUsuarioSp tipoUsuarioAtualizado);
        void AtualizarIdUrl(int idTipoUsuario, TipoUsuarioSp tipoUsuarioAtualizado);
        void Deletar(int idTipoUsuario);
    }
}
