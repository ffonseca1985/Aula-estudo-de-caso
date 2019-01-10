using System;
using System.ServiceModel;

namespace Sistran.ControleAcessosService
{
    [ServiceContract]
    public interface ITokenService
    {
        [OperationContract]
        Token GenerateToken();

        [OperationContract]
        bool ValidateToken(Guid token);
    }
}
