using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Unidade
    {
        public Unidade()
        {
            AgendamentoVistoria = new HashSet<AgendamentoVistoria>();
            MedicaoItem = new HashSet<MedicaoItem>();
            PerfilUnidades = new HashSet<PerfilUnidades>();
            UnidadeGasometro = new HashSet<UnidadeGasometro>();
            UnidadeHidrometro = new HashSet<UnidadeHidrometro>();
        }

        public int UnidadeId { get; set; }
        public string UnidadeDsc { get; set; }
        public short CondominioTorresId { get; set; }
        public short CondominioId { get; set; }
        public decimal? ClienteId { get; set; }
        public int UnidadeUltimoHidrometroId { get; set; }
        public int UnidadeUltimoGasometroId { get; set; }
        public string UnidadeIdExport { get; set; }
        public bool? UnidadeInformativoDigital { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual CondominioTorres Condominio { get; set; }
        public virtual ICollection<AgendamentoVistoria> AgendamentoVistoria { get; set; }
        public virtual ICollection<MedicaoItem> MedicaoItem { get; set; }
        public virtual ICollection<PerfilUnidades> PerfilUnidades { get; set; }
        public virtual ICollection<UnidadeGasometro> UnidadeGasometro { get; set; }
        public virtual ICollection<UnidadeHidrometro> UnidadeHidrometro { get; set; }
    }
}
