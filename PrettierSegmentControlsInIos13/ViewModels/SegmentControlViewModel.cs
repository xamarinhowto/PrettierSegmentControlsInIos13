using System;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrettierSegmentControlsInIos13.ViewModels
{
    public class SegmentControlViewModel : BaseViewModel
    {
        public SegmentControlViewModel()
        {
            Title = "iOS 13 Segment Controls";
        }

        public Color SegmentTintColor { get; set; } = Color.FromHex("#0993DB");

        public Color SegmentBackgroundColor { get; set; } = Color.FromHex("#999999");

        public Color SegmentTextColor { get; set; } = Color.FromHex("#555555");

        public ICommand SetTintColorCommand
        {
            get
            {
                return new Command((object color) =>
               {
                   SegmentTintColor = Color.FromHex(color.ToString());
               });
            }
        }

        public ICommand SetBackgroundColorCommand
        {
            get
            {
                return new Command((object color) =>
                {
                    SegmentBackgroundColor = Color.FromHex(color.ToString());
                });
            }
        }

        public ICommand SetTextColorCommand
        {
            get
            {
                return new Command((object color) =>
                {
                    SegmentTextColor = Color.FromHex(color.ToString());
                });
            }
        }
    }
}