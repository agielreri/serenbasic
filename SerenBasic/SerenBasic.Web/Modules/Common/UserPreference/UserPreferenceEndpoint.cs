using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using MyRepository = SerenBasic.Common.Repositories.UserPreferenceRepository;
using MyRow = SerenBasic.Common.Entities.UserPreferenceRow;

namespace SerenBasic.Common.Endpoints
{
    [Route("Services/Common/UserPreference/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class UserPreferenceController : ServiceEndpoint
    {
        [HttpPost]
        public ServiceResponse Update(IUnitOfWork uow, UserPreferenceUpdateRequest request)
        {
            return new MyRepository(Context).Update(uow, request);
        }

        public UserPreferenceRetrieveResponse Retrieve(IDbConnection connection, UserPreferenceRetrieveRequest request)
        {
            return new MyRepository(Context).Retrieve(connection, request);
        }
    }
}
