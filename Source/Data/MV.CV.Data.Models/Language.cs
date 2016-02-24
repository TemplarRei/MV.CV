namespace MV.CV.Data.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using Common.Models;

    public class Language : BaseModel<int>
    {
        public string Name { get; set; }

        [DisplayName("Oral Proficiency")]
        public string OralProficiency { get; set; }

        [DisplayName("Written Proficiency")]
        public string WrittenProficiency { get; set; }

        [ForeignKey("ProfileId")]
        public UserProfile Profile { get; set; }

        public int ProfileId { get; set; }
    }
}
