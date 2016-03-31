using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class PatternsModel
    {
        //TODO: GET AVAILABLE PATTERNS AND MAKE RADIO BUTTON CREATION DYNAMIC
        private StringBuilder _message;
        private Dictionary<string, string> _availablePatterns; 

        public event EventHandler ModelUpdated;

        public PatternsModel()
        {
            _availablePatterns = new Dictionary<string, string>();
            _availablePatterns.Add("AbstractFactory", "Abstract Factory");
            _availablePatterns.Add("Builder", "Builder");
            _availablePatterns.Add("Factory", "Factory");
        }

        public StringBuilder PatternMessage
        {
            get{return _message;}
        }

        public Dictionary<string, string> AvailablePatterns
        {
            get { return _availablePatterns;}
        }

        public void RunPattern(string pattern)
        {
            if (_availablePatterns.ContainsValue(pattern))
            {
                _message = new StringBuilder(pattern + " pattern run");
                if (ModelUpdated != null)
                {
                    ModelUpdated(this, EventArgs.Empty);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException(pattern + " not available.");
            }
        }
    }
}
