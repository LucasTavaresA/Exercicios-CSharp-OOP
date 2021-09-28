using System;
using System.Collections.Generic;
using System.Text;

namespace _25_exercicio_pedidos.Entities.Enums
{
    enum OrderStatus : int
    {
        Pending = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
