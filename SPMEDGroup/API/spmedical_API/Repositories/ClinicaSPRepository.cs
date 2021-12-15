using spmedical_API.Contexts;
using spmedical_API.Domains;
using spmedical_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_API.Repositories
{
    public class ClinicaSPRepository : IClinicaSPRepository
    {

        SPMedicalContext ctx = new SPMedicalContext();

        public void AtualizarIdCorpo(ClinicaSp clinicaAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int IdClinica, ClinicaSp clinicaAtualizada)
        {
            ClinicaSp clinicaBuscada = BuscarPorId(IdClinica);

            if (clinicaAtualizada != null)
            {
                clinicaBuscada.NomeClinica = clinicaAtualizada.NomeClinica;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.Cnpj = clinicaAtualizada.Cnpj;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.Endereco = clinicaAtualizada.Endereco;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.RazaoSocial = clinicaAtualizada.RazaoSocial;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.HoraFuncional = clinicaAtualizada.HoraFuncional;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.HoraFechamento = clinicaAtualizada.HoraFechamento;
            }
            ctx.ClinicaSps.Update(clinicaBuscada);
            ctx.SaveChanges();
        }

        public ClinicaSp BuscarPorId(int IdClinica)
        {
            return ctx.ClinicaSps.FirstOrDefault(U => U.IdClinica == IdClinica);
        }

        public void Cadastrar(ClinicaSp novaClinica)
        {
            ctx.ClinicaSps.Add(novaClinica);
            ctx.SaveChanges();
        }

        public void Deletar(int IdClinica)
        {
            ClinicaSp clinicaBuscada = BuscarPorId(IdClinica);
            ctx.ClinicaSps.Remove(clinicaBuscada);
            ctx.SaveChanges();
        }

        public List<ClinicaSp> ListarTodos()
        {
            return ctx.ClinicaSps.ToList();

        }
    }
}
