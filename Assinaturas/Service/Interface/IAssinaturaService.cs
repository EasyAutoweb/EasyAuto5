using System;
using System.Collections.Generic;
using Assinaturas.Entities;
using MongoDB.Bson;

namespace Assinaturas.Service.Interface
{
    public interface IAssinaturaService
    {
        Assinatura BuscarAssinatura(string id);
        List<Assinatura> BuscarTodasAssinaturas();
        void AdicionarAssinatura(Assinatura assinatura);
        void RemoverAssinatura(string id);
        void AtualizarAssinatura(Assinatura assinatura);
    }
}
