using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class QuestSocialCondominio
    {
        public short CondominioId { get; set; }
        public short QuestSocialId { get; set; }
        public short QuestSocialCondominioOrdem { get; set; }
        public bool QuestSocialCondominioObr { get; set; }

        public virtual Condominio Condominio { get; set; }
        public virtual QuestSocial QuestSocial { get; set; }
    }
}
