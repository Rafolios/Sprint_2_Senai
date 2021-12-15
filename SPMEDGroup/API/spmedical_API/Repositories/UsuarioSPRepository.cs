using spmedical_API.Contexts;
using spmedical_API.Domains;
using spmedical_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Repositories
{
    public class UsuarioSPRepository : IUsuarioSPRepository
    {
        SPMedicalContext ctx = new SPMedicalContext();

        public void AtualizarIdCorpo(UsuarioSp usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int IdUsuario, UsuarioSp usuarioAtualizado)
        {
            UsuarioSp usuarioBuscado = BuscarPorId(IdUsuario);
            
            if (usuarioAtualizado.NomeUsuario != null)
            {
               
                usuarioBuscado.NomeUsuario = usuarioAtualizado.NomeUsuario;
            }

            if (usuarioAtualizado.Senha != null)
            {
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
            }

            ctx.UsuarioSps.Update(usuarioBuscado);
            ctx.SaveChanges();
        }

        public UsuarioSp BuscarPorId(int IdUsuario)
        {
            return ctx.UsuarioSps.FirstOrDefault(U => U.IdUsuario == IdUsuario);
        }

        public void Cadastrar(UsuarioSp novoUsuario)
        {
            ctx.UsuarioSps.Add(novoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int IdUsuario)
        {
            UsuarioSp usuarioBuscado = BuscarPorId(IdUsuario);
            ctx.UsuarioSps.Remove(usuarioBuscado);
            ctx.SaveChanges();
        }

        public List<UsuarioSp> ListarTodos()
        {
            //retorna lista com todos os usuários
            return ctx.UsuarioSps.ToList();
        }

        public UsuarioSp Login(string Email, string Senha)
        {
            return ctx.UsuarioSps.FirstOrDefault(u => u.Email == Email && u.Senha == Senha);
        }
    }
}
