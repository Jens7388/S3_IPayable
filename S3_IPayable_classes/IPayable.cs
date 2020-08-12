using System;
using System.Collections.Generic;
using System.Text;

namespace S3_IPayable_classes
{
    public interface IPayable
    {
        bool IsProcessed { get; set; }
        decimal GetAmount();
    }
}