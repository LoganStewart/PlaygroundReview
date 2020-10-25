using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PlaygroundReview.Models
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

        
        public int NumberOfSwings { get; set; }
        public int NumberOfToddlerSwings { get; set; }

        //Tables
        //Benches
        //Parking
        //Features
        

        public GroundTexture GroundTexture { get; set; }


    }
}
