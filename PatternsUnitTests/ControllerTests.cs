using System;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternsUI.Controller;
using PatternsUI.Exceptions;

namespace PatternsUnitTests
{
    [TestClass]
    public class ControllerTests
    {
        private MainController _controller ;

        [TestMethod]
        public void TestControllerCreation()
        {
            try
            {
                _controller = new MainController();
                Assert.IsNotNull(_controller);
                Assert.IsNotNull(_controller.Model);
                Assert.IsNotNull(_controller.View);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestNullModel()
        {
            if (_controller == null)
            {
                try
                {
                    _controller = new MainController();
                }
                catch (Exception e)
                {
                    Assert.Fail("Exception " + e.GetType().Name + " thrown.");
                }
            }

            _controller.Model = null;
            Assert.IsNull(_controller.Model);
        }

        [TestMethod]
        public void TestNullView()
        {
            if (_controller == null)
            {
                try
                {
                    _controller = new MainController();
                }
                catch (Exception e)
                {
                    Assert.Fail("Exception " + e.GetType().Name + " thrown.");
                }
            }

            _controller.View = null;
            Assert.IsNull(_controller.View);
        }

        [TestMethod]
        public void TestShowHideView()
        {
            if (_controller == null)
            {
                try
                {
                    _controller = new MainController();
                }
                catch (Exception e)
                {
                    Assert.Fail("Exception " + e.GetType().Name + " thrown.");
                }
            }
            
            _controller.ShowView();
            Assert.IsTrue(((Window)_controller.View).Visibility == Visibility.Visible);
            _controller.HideView();
            Assert.IsTrue(((Window)_controller.View).Visibility == Visibility.Hidden);
            _controller.View = null;
            try
            {
                _controller.ShowView();
                Assert.Fail("View is null. How can it be visible? It shouldn't be.");
            }
            catch (ViewNotCreatedException viewNotCreated)
            {
                //we want this
            }
            catch(Exception e)
            {
                Assert.Fail("Error when testing view not visible. " + e.Message);
            }
            
            _controller.View = null;
            _controller = null;
        }

        [TestMethod]
        public void TestPatternChangedEventHandler()
        {
            ViewChangedEventArgs args = new ViewChangedEventArgs {NewPattern = "Builderddd"};

            try
            {
                CreateController();
            }
            catch (Exception e)
            {
                Assert.Fail("Could not create controller." + e.Message);
            }

            PrivateObject privateObject = new PrivateObject(_controller);
            try
            {
                privateObject.Invoke("_view_PatternViewChanged", new object[] {this, args});
            }
            catch (ArgumentOutOfRangeException outOfRangeException)
            {
                //success!
            }
            catch (Exception e)
            {
                Assert.Fail("Something happened: " + e.Message);
            }
        }

        //TODO: PUT THIS CALL EVERYWHERE YOU INITIALIZE CONTROLLER EXCEPT FOR WHERE YOU ACTUALLY TEST IT.
        private void CreateController()
        {
            if (_controller == null)
            {
                _controller = new MainController();
            }
        }
    }
}
