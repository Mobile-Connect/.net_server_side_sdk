AuthenticationService.ValidateTokenResponse Method
==================================================
Executes a series of validation methods on the token response, if the access token or id token are invalid the result will indicate what validation criteria was not met

**Namespace:** [GSMA.MobileConnect.Authentication][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public TokenValidationResult ValidateTokenResponse(
	RequestTokenResponse tokenResponse,
	string clientId,
	string issuer,
	string nonce,
	Nullable<int> maxAge,
	JWKeyset keyset,
	string version
)
```

#### Parameters

##### *tokenResponse*
Type: [GSMA.MobileConnect.Authentication.RequestTokenResponse][2]  
Token response to validate

##### *clientId*
Type: [System.String][3]  
Client id required for validating Id token claims

##### *issuer*
Type: [System.String][3]  
Token issuer value required for validating Id token claims

##### *nonce*
Type: [System.String][3]  
Nonce value required for validating Id token claims

##### *maxAge*
Type: [System.Nullable][4]&lt;[Int32][5]>  
MaxAge value required for validating Id token claims

##### *keyset*
Type: [GSMA.MobileConnect.Authentication.JWKeyset][6]  
Keyset required for validating Id token signature

##### *version*
Type: [System.String][3]  
Max version of mobile connect services supported by current provider, used to skip some unsupported validation steps

#### Return Value
Type: [TokenValidationResult][7]  
TokenValidationResult indicating the token response is valid or why the token response is invalid
#### Implements
[IAuthenticationService.ValidateTokenResponse(RequestTokenResponse, String, String, String, Nullable&lt;Int32>, JWKeyset, String)][8]  


See Also
--------

#### Reference
[AuthenticationService Class][9]  
[GSMA.MobileConnect.Authentication Namespace][1]  

[1]: ../README.md
[2]: ../RequestTokenResponse/README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/b3h38hb0
[5]: http://msdn.microsoft.com/en-us/library/td2s409d
[6]: ../JWKeyset/README.md
[7]: ../TokenValidationResult/README.md
[8]: ../IAuthenticationService/ValidateTokenResponse.md
[9]: README.md
[10]: ../../_icons/Help.png