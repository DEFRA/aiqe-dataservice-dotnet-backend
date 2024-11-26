using Microsoft.AspNetCore.Builder;

namespace AiqeDataserviceDotnetBackend.Test.Config;

public class EnvironmentTest
{

   [Fact]
   public void IsNotDevModeByDefault()
   {
      var _builder = WebApplication.CreateBuilder();

      var isDev = AiqeDataserviceDotnetBackend.Config.Environment.IsDevMode(_builder);

      Assert.False(isDev);
   }
}
