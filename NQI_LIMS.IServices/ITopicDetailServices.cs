using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NQI_LIMS.IServices
{
    public interface ITopicDetailServices : IBaseServices<TopicDetail>
    {
        Task<List<TopicDetail>> GetTopicDetails();
    }
}
