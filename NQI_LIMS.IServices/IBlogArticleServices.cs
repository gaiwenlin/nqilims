using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model;
using NQI_LIMS.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NQI_LIMS.IServices
{
    public interface IBlogArticleServices :IBaseServices<BlogArticle>
    {
        Task<List<BlogArticle>> GetBlogs();
        Task<BlogViewModels> GetBlogDetails(int id);

    }

}
