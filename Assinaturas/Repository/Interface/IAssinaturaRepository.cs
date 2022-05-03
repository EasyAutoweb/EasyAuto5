using System.Collections.Generic;
using Assinaturas.Entities;

namespace Assinaturas.Repository.Interface
{
    public interface IAssinaturaRepository
    {
        Assinatura BuscarAssinatura(int id);
        List<Assinatura> BuscarTodasAssinaturas();
        void AdicionarAssinatura(Assinatura assinatura);
        void RemoverAssinatura(int id);
        void AtualizarAssinatura(Assinatura assinatura);
    }
}
