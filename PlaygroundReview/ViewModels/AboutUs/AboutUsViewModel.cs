using System.Collections.ObjectModel;
using PlaygroundReview.Models.AboutUs;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PlaygroundReview.ViewModels.AboutUs
{
    /// <summary>
    /// ViewModel of AboutUs templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class AboutUsViewModel : BaseViewModel
    {
        #region Fields

        private string productDescription;

        private string productVersion;

        private string productIcon;

        private string cardsTopImage;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="T:PlaygroundReview.ViewModels.AboutUs.AboutUsViewModel"/> class.
        /// </summary>
        public AboutUsViewModel()
        {
            this.productDescription =
                "While living like everyone else in Calgary during the pandemic,  I saw a need to know what playgrounds would be safe for my 1 and 1/2 year yet 'fun' enough for my 4 year old.  Playgrounds around the city varried hugely.  I have my preferences, recycled rubber ground, not the dusty pea gravel, baby swings, safety.  I wanted to add a review of the ones I go to so i can keep a list for myself and others.";
            this.productIcon = App.BaseImageUrl + "Icon.png";
            this.productVersion = "1.0";
            this.cardsTopImage = App.BaseImageUrl + "Mask.png";

            this.EmployeeDetails = new ObservableCollection<AboutUsModel>
            {
                new AboutUsModel
                {
                    EmployeeName = "Logan Stewart",
                    Image = "https://media-exp1.licdn.com/dms/image/C4E03AQHojHuHmlvCjQ/profile-displayphoto-shrink_200_200/0?e=1609372800&v=beta&t=QuuflyrzKd4v_HqBYbB9hvaLm7ffZr_cYcXoqouGt5E", // App.BaseImageUrl + "ProfileImage15.png",
                    Designation = "Developer"
                }
                
            };

            this.ItemSelectedCommand = new Command(this.ItemSelected);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the top image source of the About us with cards view.
        /// </summary>
        /// <value>Image source location.</value>
        public string CardsTopImage
        {
            get
            {
                return this.cardsTopImage;
            }

            set
            {
                SetProperty(ref cardsTopImage, value);
            }
        }

        /// <summary>
        /// Gets or sets the description of a product or a company.
        /// </summary>
        /// <value>The product description.</value>
        public string ProductDescription
        {
            get
            {
                return this.productDescription;
            }

            set
            {
                SetProperty(ref productDescription, value);
            }
        }

        /// <summary>
        /// Gets or sets the product icon.
        /// </summary>
        /// <value>The product icon.</value>
        public string ProductIcon
        {
            get
            {
                return this.productIcon;
            }

            set
            {
                SetProperty(ref productIcon, value);
            }
        }

        /// <summary>
        /// Gets or sets the product version.
        /// </summary>
        /// <value>The product version.</value>
        public string ProductVersion
        {
            get
            {
                return this.productVersion;
            }

            set
            {
                SetProperty(ref productVersion, value);
            }
        }

        /// <summary>
        /// Gets or sets the employee details.
        /// </summary>
        /// <value>The employee details.</value>
        public ObservableCollection<AboutUsModel> EmployeeDetails { get; set; }

        /// <summary>
        /// Gets or sets the command that will be executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        private void ItemSelected(object selectedItem)
        {
            // Do something
        }

        #endregion
    }
}