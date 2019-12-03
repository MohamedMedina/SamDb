using System.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ApplicationBlocks.Layers;
using ApplicationBlocks.Utilities;
using ApplicationBlocks.ExceptionManagement;
using ApplicationBlocks.DatabaseServices;
using Common;
using DataAccess;

namespace Business
{
	// Summary:
	// The RequestBusiness Class.
	public partial class RequestBusiness
	{
        #region SelectRequestDynamicSearch

        public RequestList SelectRequestDynamicSearch(RequestSearch requestSearch)
        {
            DbTransaction Tran = null;
            return SelectRequestDynamicSearch(Tran, requestSearch);
        }

        public RequestList SelectRequestDynamicSearch(DbTransaction pTran, RequestSearch requestSearch)
        {
            return RequestData.SelectRequestDynamicSearch(pTran, requestSearch);
        }

        #endregion
    }
}
