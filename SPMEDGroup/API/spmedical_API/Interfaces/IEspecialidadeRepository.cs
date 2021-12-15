using spmedical_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Interfaces
{
    interface IEspecialidadeRepository
    {
        List<Especialidade> ListarTodos();
        Especialidade BuscarPorId(int idEspecialidades);
        void Cadastrar(Especialidade novoEspecialidade);
        void AtualizarIdCorpo(Especialidade especialidadeAtualizada);
        void AtualizarIdUrl(int idEspecialidades, Especialidade especialidadeAtualizada);
        void Deletar(int idEspecialidades);
    }
}
