namespace MV.CV.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using Common.Models;

    public class Certification : BaseModel<int>, IPeriodicEntity
    {
        public string Name { get; set; }

        public string Field { get; set; }

        public string Skills { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        [ForeignKey("ProfileId")]
        public UserProfile Profile { get; set; }

        public int ProfileId { get; set; }
    }
}
