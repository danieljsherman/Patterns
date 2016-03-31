using System;

namespace PatternsUI.Exceptions
{
    public class ViewNotCreatedException : Exception
    {
        public ViewNotCreatedException() : base("Could not create View.")
        {
        }
    }
}