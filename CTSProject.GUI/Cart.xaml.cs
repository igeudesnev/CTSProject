﻿using System;
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
using System.Windows.Shapes;

namespace CTSProject.GUI
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void OrderEverything(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Спасибо за ваш заказ! Сейчас с вами свяжется наш менеджер для уточнения деталей.");
        }
    }
}
