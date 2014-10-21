using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Roskilde_Resturants_App.Model;

namespace Roskilde_Resturants_App.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Resturants _event1;
        private Resturants _event2;
        private Resturants _event3;
        private Resturants _event4;

        public static Resturants ActualEvent { get; set; }


        public Resturants Event1
        {
            get { return _event1; }
            set { _event1 = value; }
        }

        public Resturants Event2
        {
            get { return _event2; }
            set { _event2 = value; }
        }

        public Resturants Event3
        {
            get { return _event3; }
            set { _event3 = value; }
        }

        public Resturants Event4
        {
            get { return _event4; }
            set { _event4 = value; }
        }

        public MainViewModel()
        {
            _event1 = new Resturants("Comwell Hotel", "A beautiful hotel in Roskilde that will surely fulfill all of your needs, it has beautiful rooms with views over the great city of Roskilde. People that stay at this hotel always leave happy and satisfied in every way possible, it sure is a place were dreams come true everyday, for every single visitor. This is not a light hearted promise and will be fullfilled.",
                 "Opening Time: 24 Hours everyday", "Avarage Room Cost: We will just decide on what you think is fair", "../assets/comwellhotel.jpg");

            _event2 = new Resturants("Pindsen Hotel", "A beautiful hotel in Roskilde that will surely fulfill all of your needs, it has beautiful rooms with views over the great city of Roskilde. People that stay at this hotel always leave happy and satisfied in every way possible, it sure is a place were dreams come true everyday, for every single visitor. This is not a light hearted promise and will be fullfilled.",
                "Opening Time: 24 Hours everyday", "Avarage Room Cost: We will just decide on what you think is fair", "../assets/pindsenhotel.jpg");

            _event3 = new Resturants("Scandic Hotel", "A beautiful hotel in Roskilde that will surely fulfill all of your needs, it has beautiful rooms with views over the great city of Roskilde. People that stay at this hotel always leave happy and satisfied in every way possible, it sure is a place were dreams come true everyday, for every single visitor. This is not a light hearted promise and will be fullfilled. ",
                "Opening Time: 24 Hours everyday", "Avarage Room Cost: We will just decide on what you think is fair", "../assets/scandichotel.jpg");

            _event4 = new Resturants("Vikingeskibs museet", "A beautiful hotel in Roskilde that will surely fulfill all of your needs, it has beautiful rooms with views over the great city of Roskilde. People that stay at this hotel always leave happy and satisfied in every way possible, it sure is a place were dreams come true everyday, for every single visitor. This is not a light hearted promise and will be fullfilled.B",
                "Opening Time: 24 Hours everyday", "Avarage Room Cost: We will just decide on what you think is fair", "../assets/billed4.jpg");

            //ActualEvent = _event2;

        }

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
    }
}
