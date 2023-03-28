using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title = "Bữa Sáng", Image = "IMG04.png",
                    Description = "Đặt thực đơn bữa sáng lành mạnh và ấm áp của chúng tôi cho một buổi sáng tuyệt vời" },
                new Pick { Title = "Bữa Trưa", Image = "IMG05.png",
                    Description = "Bữa trưa ngon miệng để giữ cho ngày của bạn ngọt ngào và vui vẻ" }
            };
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }


    public class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}