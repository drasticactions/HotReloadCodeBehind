using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HotReloadCodeBehind
{
    public partial class BaseXamlPage : ContentPage
    {
        public IList<View> BasePageContent => BaseContentGrid.Children;

        public Label TestLabel => testLabel;

        public BaseXamlPage()
        {
            InitializeComponent();
        }
    }
}
