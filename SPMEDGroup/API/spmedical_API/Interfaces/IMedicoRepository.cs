using spmedical_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Interfaces
{
    interface IMedicoRepository
    {
        List<Medico> ListarTodos();
        Medico BuscarPorId(int idMedico);
        void Cadastrar(Medico novoMedico);
        void AtualizarIdCorpo(Medico medicoAtualizado);
        void AtualizarIdUrl(int idMedico, Medico medicoAtualizado);
        void Deletar(int idMedico);
    }
}
