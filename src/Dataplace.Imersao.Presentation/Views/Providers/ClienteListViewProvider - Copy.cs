using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Entities;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views.Providers;
using Dataplace.Core.win.Views.Providers.Contracts;
using Dataplace.Imersao.Core.Application.Clientes.Queries;
using Dataplace.Imersao.Core.Application.Clientes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Presentation.Views.Providers
{
    public class VendedorListViewProvider :
        SelectableListViewProvider<VendedorViewModel, VendedorQuery>,
        ISelectableListViewProvider<VendedorViewModel, VendedorQuery>

    {
        public override void Configure(ViewModelListBuilder<VendedorViewModel> builder)
        {
            builder.Property(x => x.CdVendedor)
                .HasCaption("Código");

            builder.Property(x => x.Nome)
              .HasCaption("Razão");
        }

        public override IEnumerable<VendedorViewModel> GetDatasource(VendedorQuery filter, IEnumerable<SortDescriptor> sortings)
        {
            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {
                var m = scope.Container.GetInstance<IMediatorHandler>();
                return  m.Query(filter).Result;
            }
        }
    }
}
