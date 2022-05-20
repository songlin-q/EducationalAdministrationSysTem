using EducationalAdministrationSystem.API.Common.Helper;
using EducationalAdministrationSysTem.API.Model.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EducationalAdministrationSysTem.API.JWT
{
    public class GetJwtToken
    {
        public static string GenerateJwtToken(View_AdminInfo uInfo)
        {
            var userInfo = EducationalAdministrationSystem.API.Common.ConvertHelper.JsonAndList.SerializeObjToJson(uInfo);
            //现在，是时候定义 jwt token 了，它将负责创建我们的 tokens
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var _tokenParameter = AppSettings.app<tokenParameter>(new string[] { "JwtConfig" }).FirstOrDefault();

            // 从 appsettings 中获得我们的 secret 
            var key = Encoding.ASCII.GetBytes(_tokenParameter.Secret);

            // 定义我们的 token descriptor
            // 我们需要使用 claims （token 中的属性）给出关于 token 的信息，它们属于特定的用户，
            // 因此，可以包含用户的 Id、名字、邮箱等。
            // 好消息是，这些信息由我们的服务器和 Identity framework 生成，它们是有效且可信的。
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                //new Claim("UserInfo", userInfo), 
                new Claim(ClaimTypes.Name, userInfo), 
                // Jti 用于刷新 token，我们将在下一篇中讲到
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }),
                // token 的过期时间需要缩短，并利用 refresh token 来保持用户的登录状态，
                // 不过由于这只是一个演示应用，我们可以对其进行延长以适应我们当前的需求
                Expires = DateTime.UtcNow.AddHours(_tokenParameter.AccessExpiration),
                // 这里我们添加了加密算法信息，用于加密我们的 token
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }

        public async static Task<View_AdminInfo> GetUserInfo(HttpContext httpContext)
        {

            // 获取所存放的account
            var schemeProvider = httpContext.RequestServices.GetService(typeof(IAuthenticationSchemeProvider)) as IAuthenticationSchemeProvider;
            var defaultAuthenticate = await schemeProvider.GetDefaultAuthenticateSchemeAsync();
            if (defaultAuthenticate != null)
            {
                var result = await httpContext.AuthenticateAsync(defaultAuthenticate.Name);
                var user = result?.Principal;
                if (user != null)
                {
                    var account = user.Identity.Name;
                    if (!string.IsNullOrEmpty(account))
                    {
                        var uInfo = EducationalAdministrationSystem.API.Common.ConvertHelper.JsonAndList.DeserializeJsonToObj<View_AdminInfo>(account);
                        return uInfo;
                    }
                }

            }
            return null;
        }
    }
}
