using System;

namespace Sistran.SiteWeb.Models
{
    public class TokenViewModel
    {
        public string Id { get; set; }
        public DateTime DataExpiracao { get; set; }
        public int TimeExpire
        {
            get
            {
                return (this.DataExpiracao - DateTime.Now).Minutes;
            }
        }
    }
}