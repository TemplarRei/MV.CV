namespace MV.CV.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common.Models;

    public class Domain : BaseModel<int>
    {
        [Required]
        [ForeignKey("Owner")]
        public string OwnerId { get; set; }

        public User Owner { get; set; }

        public string HtmlContent { get; set; }
    }
}
