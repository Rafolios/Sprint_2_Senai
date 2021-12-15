using spmedical_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Interfaces
{
    interface IUsuarioSPRepository
    {
        UsuarioSp BuscarPorId(int IdUsuario);
        void Cadastrar(UsuarioSp novoUsuario);
        void AtualizarIdCorpo(UsuarioSp usuarioAtualizado);
        void AtualizarIdUrl(int idUsuario, UsuarioSp usuarioAtualizado);
        void Deletar(int IdUsuario);
        UsuarioSp Login(string Email, string Senha);

    }
}
