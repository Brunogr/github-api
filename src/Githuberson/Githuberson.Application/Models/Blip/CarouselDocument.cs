using System;
using System.Collections.Generic;
using System.Text;

namespace Githuberson.Application.Models.Blip
{       
    public class CarouselDocument
    {
        public CarouselDocument(CarouselHeader header)
        {
            this.Header = header;
        }
        public CarouselHeader Header { get; set; }
    }

    public class CarouselHeader
    {
        public CarouselHeader(string title, string text, string uri)
        {
            Type = "application/vnd.lime.media-link+json";
            Value = new HeaderValue()
            {
                Title = title,
                Text = text,
                Type = "image/jpeg",
                Uri = new Uri(uri)
            };
        }

        public string Type { get; set; }
        public HeaderValue Value { get; set; }       
    }
    public class HeaderValue
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public Uri Uri { get; set; }
    }
}
