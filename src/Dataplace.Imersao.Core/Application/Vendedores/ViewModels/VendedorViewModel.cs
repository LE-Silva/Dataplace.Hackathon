using Dataplace.Core.Application.Contracts.Results;
using Dataplace.Core.Application.ViewModels.Contracts;
using Dataplace.Core.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Clientes.ViewModels
{
    public class VendedorViewModel :  ISelectableViewModel,  IEquatable<VendedorViewModel>
    {
        public string CdVendedor { get; set; }
        public string Nome { get; set; }

        public bool IsSelected { get; set; }
        private IResult _result;

        public bool Equals(VendedorViewModel other)
        {
            return other.CdVendedor == this.CdVendedor;
        }
    }
}
