using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsUI.Controller
{
    public class ViewChangedEventArgs : EventArgs
    {
        /// <summary>
        /// The name of the requested pattern.
        /// </summary>
        public string NewPattern { get; set; }
    }
}
