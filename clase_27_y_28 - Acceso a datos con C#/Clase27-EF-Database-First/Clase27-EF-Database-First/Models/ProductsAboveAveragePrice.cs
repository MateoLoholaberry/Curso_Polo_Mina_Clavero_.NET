using System;
using System.Collections.Generic;

namespace Clase27_EF_Database_First.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
