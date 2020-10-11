using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class QuestSocialAlternativa
    {
        public QuestSocialAlternativa()
        {
            QuestSocialPessoa = new HashSet<QuestSocialPessoa>();
        }

        public short QuestSocialId { get; set; }
        public short QuestSocialAlternativaId { get; set; }
        public string QuestSocialAlternativaDsc { get; set; }

        public virtual QuestSocial QuestSocial { get; set; }
        public virtual ICollection<QuestSocialPessoa> QuestSocialPessoa { get; set; }
    }
}
