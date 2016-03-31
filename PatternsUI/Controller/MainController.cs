using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Patterns;
using PatternsUI.Exceptions;

namespace PatternsUI.Controller
{
    /// <summary>
    /// This is a classic controller class. It contains a reference to both the view and the model.
    /// The controller responds to events that the view triggers and updates the model accordingly.
    /// The view also has a reference to the model and it gets the model's changes when something happens.
    /// </summary>
    public class MainController
    {
        private IPatternView _view;
        private PatternsModel _model;

        public MainController()
        {
            try
            {
                _model = new PatternsModel();
                if (_model == null)
                {
                    throw new ModelNotCreatedException();
                }
            }
            catch (Exception modelException)
            {
                //log the actual error
                throw new ModelNotCreatedException();
            }

            try
            {
                _view = new MainWindow();
                if (_view == null)
                {
                    throw new ViewNotCreatedException();
                }
                _view.PatternViewChanged += _view_PatternViewChanged;
                //we can set the model because if we got this far then the model exists
                _view.Model = _model;
            }
            catch (Exception viewException)
            {
                //log the actual error
                throw new ViewNotCreatedException();
            }
        }

        public PatternsModel Model
        {
            get { return _model; } 
            set { _model = value; }
        }

        public IPatternView View
        {
            get { return _view;}
            set { _view = value; }
        }

        public void ShowView()
        {
            if (_view != null)
            {
                ((Window) _view).Show();
            }
            else
            {
                throw new ViewNotCreatedException();
            }
        }

        public void HideView()
        {
            ((Window)_view).Hide();
        }

        private void _view_PatternViewChanged(object sender, EventArgs e)
        {
            if (e.GetType() == typeof (ViewChangedEventArgs))
            {
                try
                {
                    _model.RunPattern(((ViewChangedEventArgs) e).NewPattern);
                }
                catch (ArgumentOutOfRangeException outOfRangeException)
                {
                    _view.HandleError(outOfRangeException.Message);
                }
                catch
                {
                    //some error that we don't know about
                    //log the error and do something.
                }
            }
        }
    }
}
