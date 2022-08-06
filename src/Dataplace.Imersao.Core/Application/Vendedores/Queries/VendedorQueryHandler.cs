using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.Imersao.Core.Application.Clientes.ViewModels;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;
using dpLibrary05;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Clientes.Queries
{
    public class VendedorQueryHandler:
           IRequestHandler<VendedorQuery, IEnumerable<VendedorViewModel>>
    {
        #region fields
        private readonly IDataAccess _dataAccess;
        #endregion


        #region contructors
        public VendedorQueryHandler(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        #endregion

        #region Vendedors
        public async Task<IEnumerable<VendedorViewModel>> Handle(VendedorQuery request, CancellationToken cancellationToken)
        {
            var sql = $@"
            SET TRANSACTION ISOLATION LEVEL SNAPSHOT;

            SELECT 
		        Vendedor.CdVendedor, 
                Vendedor.Nome AS Nome
	        FROM Vendedor 

            /**where**/	
            /**orderby**/
            ";
            var builder = new SqlBuilder();
            var selector = builder.AddTemplate(sql);

            builder.Where("Vendedor.stativo = 1");

            builder.OrderBy("Vendedor.Nome DESC");

            var cmd = new CommandDefinition(selector.RawSql, selector.Parameters, flags: CommandFlags.NoCache);

            return _dataAccess.Connection.Query<VendedorViewModel>(cmd);
        }

        #endregion
    }
}
