using WebApiFakeData.BLL.Implementations.Production;
using WebApiFakeData.BLL.Interfaces.Production;

namespace WebApiFakeData.Configurations
{
    public static class DependencyInjections
    {
        public static void AddBll(this IServiceCollection services)
        {
            services.AddScoped<IWebsiteCommentBLL, WebsiteCommentBLL>();
        }
    }
}
