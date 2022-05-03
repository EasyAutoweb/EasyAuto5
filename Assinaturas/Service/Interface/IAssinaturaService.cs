using System.Collections.Generic;
using Assinaturas.Entities;

namespace Assinaturas.Service.Interface
{
    public interface IAssinaturaService
    {
        Assinatura BuscarAssinatura(int id);
        List<Assinatura> BuscarTodasAssinaturas();
        void AdicionarAssinatura(Assinatura assinatura);
        void RemoverAssinatura(int id);
        void AtualizarAssinatura(Assinatura assinatura);
    }
}
