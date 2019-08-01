using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HotReloadCodeBehind
{
    public class BasePage : ContentPage
    {
        Label TestLabel;
        Grid BaseContentGrid;
        public IList<View> BasePageContent => BaseContentGrid.Children;

        public BasePage()
        {
            TestLabel = new Label
            {
                Text = "Awesome",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            BaseContentGrid = new Grid()
            {
                RowSpacing = 0,
                ColumnSpacing = 0,
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    TestLabel,
                    BaseContentGrid
                }
            };
        }

        //void InitializeComponent()
        //{
        //    TestLabel = new Label
        //    {
        //        Text = "Awesome",
        //        VerticalOptions = LayoutOptions.CenterAndExpand,
        //        HorizontalOptions = LayoutOptions.CenterAndExpand
        //    };

        //    BaseContentGrid = new Grid()
        //    {
        //        RowSpacing = 0,
        //        ColumnSpacing = 0,
        //        BackgroundColor = Color.White,
        //        VerticalOptions = LayoutOptions.FillAndExpand,
        //        HorizontalOptions = LayoutOptions.FillAndExpand
        //    };

        //    Content = new StackLayout
        //    {
        //        HorizontalOptions = LayoutOptions.CenterAndExpand,
        //        Children = {
        //            TestLabel,
        //            BaseContentGrid
        //        }
        //    };
        //}
    }
}

