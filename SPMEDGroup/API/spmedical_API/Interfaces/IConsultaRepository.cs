using spmedical_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Interfaces
{
    interface IConsultaRepository 
    {
        List<Consultum> ListarTodos();
        Consultum BuscarPorId(int idConsulta);
        void Cadastrar(Consultum novoConsulta);
        void AtualizarIdCorpo(Consultum consultaAtualizada);
        void AtualizarIdUrl(int idConsulta, Consultum consultaAtualizada);
        void Deletar(int idConsulta);
    }
}
