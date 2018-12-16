using System;
using System.Collections.Generic;
using System.Text;

namespace Githuberson.Application.Models.Blip
{
    public class BlipDocument
    {
        public BlipDocument(CarouselDocument[] carouselDocument)
        {
            ItemType = "application/vnd.lime.document-select+json";
            Items = carouselDocument;
        }

        public string ItemType { get; set; }
        public CarouselDocument[] Items { get; set; }
    }
}
