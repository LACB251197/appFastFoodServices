//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppFastFoodService.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PedidoFastFood
    {
        public string CodigoPedido { get; set; }
        public int IdProveedor { get; set; }
        public int IdCliente { get; set; }
        public decimal ImporteTot { get; set; }
        public System.DateTime FechaPedido { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public string IdEstadoPedido { get; set; }
    }
}