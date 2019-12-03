using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.Helpers
{
    public class Copier
    {
        public static UserGroup copyUserGroup(UserGroup _UserGroup)
        {
            UserGroup UserGroupOutput = new UserGroup();

            UserGroupOutput.groupId = _UserGroup.groupId;
            UserGroupOutput.Id = _UserGroup.Id;
            UserGroupOutput.userId = _UserGroup.userId;

            return UserGroupOutput;
        }

        public static RequestDetail copyRequestDetail(RequestDetail requestDetail)
        {
            RequestDetail RequestDetailOutput = new RequestDetail();

            RequestDetailOutput.Id = requestDetail.Id;
            RequestDetailOutput.quantity = requestDetail.quantity;
            RequestDetailOutput.cardTypeID = requestDetail.cardTypeID;
            RequestDetailOutput.requestID = requestDetail.requestID;

            return RequestDetailOutput;
        }
    }
}
