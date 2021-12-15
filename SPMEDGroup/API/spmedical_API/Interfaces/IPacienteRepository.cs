using spmedical_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Interfaces
{
    interface IPacienteRepository
    {
        List<Paciente> ListarTodos();
        Paciente BuscarPorId(int idPaciente);
        void Cadastrar(Paciente novoPaciente);
        void AtualizarIdCorpo(Paciente pacienteAtualizado);
        void AtualizarIdUrl(int idPaciente, Paciente pacienteAtualizado);
        void Deletar(int idPaciente);
    }
}
