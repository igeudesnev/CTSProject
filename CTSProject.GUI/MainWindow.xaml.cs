﻿using CTSProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CTSProject.UI;
using CTSProject.Data.Model;

namespace CTSProject.GUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IEnumerable<Product> _products;
        UnitOfWork _unit;
        IEnumerable<Category> _categories;

        public MainWindow()
        {
            InitializeComponent();

            CategoriesToListbox();
            ProductsToListbox();

            //Преобразовать название категорий, чтобы выводить их в лист
            //Categories.ItemSourse = Имя Листа С Категориями, где названия в графе Name
        }

        private void ProductsToListbox()
        {
            Items.ItemsSource = _products;
        }

        private void CategoriesToListbox()
        {
            Items.ItemsSource = _categories;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (_unit = new UnitOfWork())
            {
                Login LoginWindow = new Login();
                LoginWindow.Show();
                LoginWindow.Owner = this;
                IsHitTestVisible = false;
                _products = _unit.Products.Read();
                _categories = _unit.Categories.Read();
            }
        }

        private void Cart_Click(object sender, RoutedEventArgs e)
        {
            bool opened = false;
            if (OwnedWindows != null)
            {
                foreach (Window window in OwnedWindows)
                {
                    if (window is Cart)
                        opened = true;
                    MessageBox.Show("Корзина уже открыта!");
                }
            }
            if (!opened)
            {
                Cart CartWindow = new Cart();
                CartWindow.Owner = this;
                CartWindow.Show();
            }
        }

        private void Category_Selected(object sender, RoutedEventArgs e)
        {

            _unit.Products.CategorySort((Category)Categories.SelectedItem, _products);
            
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
