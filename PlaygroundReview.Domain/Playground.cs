using System.Collections.Generic;
using System.Drawing;
using Xamarin.Essentials;

namespace PlaygroundReview.Domain
{
    public class Playground
    {
      
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public Location Location { get; set; }

        public List<Image> Images { get; set; }


        public bool SafeForUnder2 { get; set; }
        public bool SafeFor2To4 { get; set; }

       
        public List<Parking> Parking { get; set; }
        public List<Features> Features { get; set; }

        public List<GroundTexture> GroundTexture { get; set; }


    }
}
