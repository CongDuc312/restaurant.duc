using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }

        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "Sushi", Image = "IMG05.png", Description = "Shashimi cá hồi và Shusi cá hồi tổng hợp ngon khó cưỡng dành cho 'fan cứng' của Shusi", Price = "299.000đ" },
                new Pick { Title = "Salad ", Image = "IMG04.png", Description = "Chế biến từ các loại rau củ được thu hoạch tại vườn, đảm bảo vừa ăn ngon vừa tốt cho sức khỏe.", Price = "199.000đ" },
                new Pick { Title = "Bò ' Lúc Lắc ' ", Image = "IMG01.png", Description = "Burger bò hảo hạng phủ phô mai jack tiêu và thịt xông khói giòn.", Price = "399.000đ" }
            };
        }
    }
}