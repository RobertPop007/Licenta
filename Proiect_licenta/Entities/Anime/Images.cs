using System;
using System.ComponentModel.DataAnnotations;

namespace Proiect_licenta.Entities.Anime
{
    public class Images
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Jpg Jpg { get; set; }
        public Webp Webp { get; set; }
        public string Image_url { get; set; }
        public string Small_image_url { get; set; }
        public string Medium_image_url { get; set; }
        public string Large_image_url { get; set; }
        public string Maximum_image_url { get; set; }
    }
}
