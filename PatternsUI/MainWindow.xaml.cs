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
using Patterns;
using PatternsUI.Controller;

namespace PatternsUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Impliments IPatternView so the controller can be sure
    /// that it has what it needs.
    /// </summary>
    public partial class MainWindow : Window, IPatternView
    {
        private string _selectedRadioButton;
        private PatternsModel _model;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PatternButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (e.Source.GetType() == typeof (RadioButton))
            {
                RadioButton buttonClicked = (RadioButton) e.Source;
                _selectedRadioButton = buttonClicked.Content.ToString();
            }
        }

        private void BtnDisplay_OnClick(object sender, RoutedEventArgs e)
        {
            if (PatternViewChanged != null)
            {
                PatternViewChanged(this, new ViewChangedEventArgs{NewPattern = _selectedRadioButton});
            }
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        #region IPatternView Members

        public event EventHandler PatternViewChanged;

        public PatternsModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                _model.ModelUpdated += (sender, args) => StatusMsg.Text = _model.PatternMessage.ToString();
            }
        }

        public void HandleError(string errorMessage)
        {
            StatusMsg.Text = "";
            lblErrorMessage.Content = errorMessage;
        }

        #endregion
    }
}
