﻿using System.Windows;

namespace Core
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var theOtherKeyDataTemplateByEnum = Application.Current.TryFindResource(ResourceKeys.TheOtherKey);
            var theOtherKeyDataTemplateByString = Application.Current.TryFindResource("TheOtherKey");

            var dataTemplateByEnumKeyAndWithDataType = Application.Current.TryFindResource(ResourceKeys.AKey);
        }
    }
}
