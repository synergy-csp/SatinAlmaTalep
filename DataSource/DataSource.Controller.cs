using Bimser.CSP.DataSource.Api.Base;
using Bimser.CSP.DataSource.Api.Models;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace BCD_SATINALMATALEP.DataSources 
{
    [Route ("api/DataSource/[action]")]
    [Produces ("application/json")]
    public class DataSourceController : BaseDataSourceController 
    {

        #region [.ctor]

        public DataSourceController (IIocManager iocManager, string authorization = "", string bimserEncryptedData = "", string bimserLanguage = "") : base (iocManager, authorization, bimserEncryptedData, bimserLanguage) 
        {

        }

        #endregion

        ///Actions
        

        ///Handles
        

    }
}