namespace ArtGallery.Models
{
    public class Art
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string origin { get; set; }

        public Boolean areyoutheartist { get; set; }

        public Boolean wantstosell { get; set; }

        public int amount { get; set; }

        public Art() { }
    }
}
