namespace MV.CV.Data.Models
{
    using System;

    using MV.CV.Data.Common.Models;

    public class Job : BaseModel<int>, IPeriodicEntity
    {
        public string Employer { get; set; }

        public string Position { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}
