using Microsoft.Extensions.Configuration;

namespace EmployeePayroll_v2
{
    public class MyConfig
    {
        public string Author { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string DefaultConnection { get; set; }

        public MyConfig()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            Author = config.GetSection("AppConfigSettings").GetValue<string>("Author");
            AppName = config.GetSection("AppConfigSettings").GetValue<string>("AppName");
            AppVersion = config.GetSection("AppConfigSettings").GetValue<string>("AppVersion");
            DefaultConnection = config.GetSection("ConnectionStrings").GetValue<string>("DefaultConnection");
        }
    }
}
