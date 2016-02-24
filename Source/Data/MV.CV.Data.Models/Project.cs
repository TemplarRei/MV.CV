namespace MV.CV.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Common.Models;

    public class Project : BaseModel<int>
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public int ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        public virtual UserProfile Profile { get; set; }
    }
}
