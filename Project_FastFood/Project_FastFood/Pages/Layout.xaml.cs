﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
<<<<<<< HEAD
=======
using Project_FastFood.Models;
>>>>>>> parent of ae6be87 (Update)

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Project_FastFood.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();
<<<<<<< HEAD
        }

        private void HomeNavigate(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Home));
=======
            MainFrame.Navigate(typeof(Pages.Home));
        }

        //private void HomeNavigate(object sender, RoutedEventArgs e)
        //{
        //    MainFrame.Navigate(typeof(Pages.Home));
        //}

        private void menuList_Loaded(object sender, RoutedEventArgs e)
        {
            // Add item to loaded
            menuList.Items.Add(new MenuItem("\uE770", "Home", "home"));
            menuList.Items.Add(new MenuItem("\uE80F", "Eat-in", "eat-in"));
            menuList.Items.Add(new MenuItem("\uE8FD", "Collection", "collection"));
            menuList.Items.Add(new MenuItem("\uE7EC", "Delivery", "delivery"));
            menuList.Items.Add(new MenuItem("\uED56", "Take Away", "take away"));
            menuList.Items.Add(new MenuItem("\uE8C7", "Driver Payment", "driver payment"));
            menuList.Items.Add(new MenuItem("\uE716", "Customers", "customers"));
        }

        private void menuList_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = menuList.SelectedItem as MenuItem; // MenuItem Clicked
            switch (selectedItem.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "eat-in": MainFrame.Navigate(typeof(Pages.Eat_In)); break;
                case "collection": MainFrame.Navigate(typeof(Pages.Collection), "This is Collection Page"); break;
                case "delivery": MainFrame.Navigate(typeof(Pages.Delivery), "This is Delivery Page"); break;
                case "take away": MainFrame.Navigate(typeof(Pages.Take_Away), "This is Take Away Page"); break; 
                case "driver payment": MainFrame.Navigate(typeof(Pages.Driver_Payment), "This is Driver Payment Page"); break; 
                case "customers": MainFrame.Navigate(typeof(Pages.Customer), "This is Customer Page"); break; 
            }
>>>>>>> parent of ae6be87 (Update)
        }
    }
}