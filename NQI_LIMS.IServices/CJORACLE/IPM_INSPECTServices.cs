using Newtonsoft.Json.Linq;
using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model;
using System.Threading.Tasks;

namespace NQI_LIMS.IServices
{
    public interface IPM_INSPECTServices : IBaseServices<PM_PLAN_SUB>
    {
        JObject GetPmInsPectByCode(int iUserId, string iCodeNum);
    }
}
