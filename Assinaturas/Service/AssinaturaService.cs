using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assinaturas.Entities;
using Assinaturas.Repository.Interface;
using Assinaturas.Service.Interface;
using MongoDB.Bson;

namespace Assinaturas.Service
{
    public class AssinaturaService : IAssinaturaService
    {
        private IAssinaturaRepository _assinaturaRepository;

        public AssinaturaService(IAssinaturaRepository assinaturaRepository)
        {
            _assinaturaRepository = assinaturaRepository;
        }

        public void AdicionarAssinatura(Assinatura assinatura)
        {
            _assinaturaRepository.AdicionarAssinatura(assinatura);
        }

        public void AtualizarAssinatura(Assinatura assinatura)
        {
            _assinaturaRepository.AtualizarAssinatura(assinatura);
        }

        public Assinatura BuscarAssinatura(string id)
        {
            return _assinaturaRepository.BuscarAssinatura(id);
        }

        public List<Assinatura> BuscarTodasAssinaturas()
        {
            return _assinaturaRepository.BuscarTodasAssinaturas();
        }

        public void RemoverAssinatura(string id)
        {
            _assinaturaRepository.RemoverAssinatura(id);
        }
    }
}
