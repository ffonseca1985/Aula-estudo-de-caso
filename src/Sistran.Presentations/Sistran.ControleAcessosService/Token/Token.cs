using System;
using System.Runtime.Serialization;

namespace Sistran.ControleAcessosService
{
    [DataContract]
    public class Token
    {
        public Token(Guid id, DateTime dataExpiracao, bool valido)
        {
            this.Id = id;
            this.DataExpiracao = dataExpiracao;
            this.Valido = valido;
        }

        [DataMember]
        public Guid Id { get; private set; }

        [DataMember]
        public DateTime DataExpiracao { get; private set; }

        [DataMember]   
        public bool Valido { get; private set; }
    }
}