namespace MV.CV.Data.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPeriodicEntity
    {
        DateTime From { get; set; }

        DateTime To { get; set; }
    }
}
