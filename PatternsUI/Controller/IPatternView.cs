using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns;

namespace PatternsUI.Controller
{
    public interface IPatternView
    {
        event EventHandler PatternViewChanged;
        PatternsModel Model { get; set; }
        void HandleError(string errorMessage);
    }
}
