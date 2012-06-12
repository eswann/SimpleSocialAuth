using System.Collections.Generic;
using System.Web;

namespace SimpleSocialAuth.MVC4.Handlers
{
  public abstract class AbstractAuthHandler
  {
    public abstract string PrepareAuthRequest(HttpRequestBase request, string redirectPath, IDictionary<string, string> parameters = null);
    public abstract BasicUserData ProcessAuthRequest(HttpRequestBase request);
  }
}
