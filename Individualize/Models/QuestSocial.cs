using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class QuestSocial
    {
        public QuestSocial()
        {
            QuestSocialAlternativa = new HashSet<QuestSocialAlternativa>();
            QuestSocialCondominio = new HashSet<QuestSocialCondominio>();
            QuestSocialPessoa = new HashSet<QuestSocialPessoa>();
        }

        public short QuestSocialId { get; set; }
        public string QuestSocialDsc { get; set; }
        public string QuestSocialTipoResposta { get; set; }
        public short QuestSocialUltAlternativaId { get; set; }
        public bool QuestSocialOutrosFlag { get; set; }
        public string QuestSocialOutrosDsc { get; set; }
        public string QuestSocialQtdUnidade { get; set; }

        public virtual ICollection<QuestSocialAlternativa> QuestSocialAlternativa { get; set; }
        public virtual ICollection<QuestSocialCondominio> QuestSocialCondominio { get; set; }
        public virtual ICollection<QuestSocialPessoa> QuestSocialPessoa { get; set; }
    }
}
