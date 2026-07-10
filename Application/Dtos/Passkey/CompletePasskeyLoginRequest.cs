using Fido2NetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Passkey
{
    public record CompletePasskeyLoginRequest(
        string Identifier,
        AuthenticatorAssertionRawResponse Assertion
        );

}
