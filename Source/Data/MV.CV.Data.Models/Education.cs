﻿namespace MV.CV.Data.Models
{
    using System;
    using Common.Models;

    public class Education : BaseModel<int>, IPeriodicEntity
    {
        public string SchoolName { get; set; }

        public string Degree { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}
