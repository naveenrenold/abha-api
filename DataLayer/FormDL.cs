using System.Data;
using AbhaApi.DataLayer.Interface;
using AbhaApi.Model;
using AbhaApi.Startup;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Query = AbhaApi.Constants.Query;

namespace AbhaApi.DataLayer
{
    public class FormDL(IDbConnection dbconnection, IOptions<AppSettings> appSettings) : BaseRepository, IFormDL
    {
        private readonly IDbConnection conn = dbconnection;

        public async Task<IEnumerable<FormResponse>> GetForm(QueryFilter<FormResponse> filter)
        {
            var query = Query.Form.getForm;
            var form = new DynamicParameters();
            query = BuildQuery(filter, query, ref form);
            return await conn.QueryAsync<FormResponse>(query, form);
        }
    }
}
