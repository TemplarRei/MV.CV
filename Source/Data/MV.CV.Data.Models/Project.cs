namespace MV.CV.Data.Models
{
    using Common.Models;

    public class Project : BaseModel<int>
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }
}
