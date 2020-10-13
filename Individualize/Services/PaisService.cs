using Individualize.libs;
using Individualize.Models;
using Individualize.Interfaces;
using System.Collections.Generic;
using Individualize.Services.Commons;

namespace Individualize.Services
{
    public class PaisService
    {

        private readonly IPaisRepository _paisRepository;

        public PaisService(IPaisRepository pais)
        {
            _paisRepository = pais;
        }
        
        public string ModelSerializale()
        {  
            return Json.ToJson(new Pais());                
        }

        public IEnumerable<Pais> Listar(Pais paisVo)
        {
            return _paisRepository.Listar(paisVo);
        }

        public Pais Cadastrar(Pais pais)
        {
            ValidarModelo(pais);

            return _paisRepository.Inserir(pais);
        }

        public IEnumerable<Pais> Lov(string nome=null)
        {
            var filtro = new Pais();
            filtro.PaisDsc = (nome != "null")? nome : null;

            return _paisRepository.Listar(filtro);
        }

        public void Editar(Pais pais)
        {
            ValidarModelo(pais);
            _paisRepository.Atualizar(pais);
        }

        public void Excluir(int id)
        {

            if (id == 0)
            {
                throw new MensagemException(EnumStatusCode.RequisicaoInvalida, 
                                            "Não foi possivel excluir o Banco. Banco não localizado");
            }

            var pais = _paisRepository.PesquisarPorId(id);
            

            if (pais == null || pais.PaisId == 0)
            {
                throw new MensagemException(EnumStatusCode.RequisicaoInvalida,
                                            "Não foi possivel excluir o Banco. Banco não localizado");
            }

            _paisRepository.Excluir(pais);
        }

        private void ValidarModelo(Pais pais)
        {
          
            if (string.IsNullOrEmpty(pais.PaisDsc))
            {
                throw new MensagemException(EnumStatusCode.RequisicaoInvalida, "Nome do Banco não informado");
            }           
        }
    }    
}
