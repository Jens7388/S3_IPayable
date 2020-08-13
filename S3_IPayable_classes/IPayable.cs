using System;
using System.Collections.Generic;
using System.Text;

namespace S3_IPayable_classes
{
    public interface IPayable
    {
        public abstract bool IsProcessed { get; set; }
        public abstract decimal GetAmount();
    }
}