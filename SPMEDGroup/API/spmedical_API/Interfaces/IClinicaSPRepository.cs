using spmedical_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Interfaces
{
    interface IClinicaSPRepository
    {
        List<ClinicaSp> ListarTodos();
        ClinicaSp BuscarPorId(int IdClinica);
        void Cadastrar(ClinicaSp novaClinica);
        void AtualizarIdCorpo(ClinicaSp clinicaAtualizada);
        void AtualizarIdUrl(int IdClinica, ClinicaSp clinicaAtualizada);
        void Deletar(int IdUsuario);
    }
}
