using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class QuestSocialPessoa
    {
        public decimal PessoaId { get; set; }
        public short QuestSocialId { get; set; }
        public string QuestSocialPessoaRespostaDsc { get; set; }
        public short? QuestSocialAlternativaId { get; set; }
        public DateTime QuestSocialPessoaData { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual QuestSocial QuestSocial { get; set; }
        public virtual QuestSocialAlternativa QuestSocialNavigation { get; set; }
    }
}
