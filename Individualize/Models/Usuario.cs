using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            LogAcesso = new HashSet<LogAcesso>();
            MedicaoItem = new HashSet<MedicaoItem>();
        }

        public decimal UsuarioId { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioChave { get; set; }
        public short PerfilId { get; set; }
        public string UsuarioCodAtivacao { get; set; }
        public short UsuarioSituacao { get; set; }
        public DateTime UsuarioIncEm { get; set; }
        public short UsuarioIncPor { get; set; }
        public DateTime? UsuarioAltEm { get; set; }
        public short? UsuarioAltPor { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual Pessoa UsuarioNavigation { get; set; }
        public virtual ICollection<LogAcesso> LogAcesso { get; set; }
        public virtual ICollection<MedicaoItem> MedicaoItem { get; set; }
    }
}
