namespace MV.CV.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using MV.CV.Data.Common.Models;

    public class Job : BaseModel<int>, IPeriodicEntity
    {
        public string Employer { get; set; }

        public string Position { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        [ForeignKey("ProfileId")]
        public UserProfile Profile { get; set; }

        public int ProfileId { get; set; }
    }
}
