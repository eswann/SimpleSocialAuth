﻿using System.Web;

namespace SimpleSocialAuth.MVC4
{
  public static class Utils
  {
    public static string GetUrlBase(HttpRequestBase request)
    {
      if (request.Url == null)
      {
        return null;
      }

      return
        request.Url.Scheme + "://" +
        request.Url.Authority;
    }
  }
}
