﻿using System;
using System.Collections.Generic;

namespace Clase27_EF_Database_First.Models;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
