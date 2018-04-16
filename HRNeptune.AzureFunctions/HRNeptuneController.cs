using nVisionIT.MIT.Common.Logging;
using Omnia.Core.Controller;

namespace Omnia.Templates
{
    public class HRNeptuneController : BaseController
    {
        public HRNeptuneController(ILogger logger)
            : base(logger)
        {
        }

        public override void Run(params object[] parameters)
        {
            int firstParameter = (int)parameters[0];
            string secondParameter = (string)parameters[1];
            Logger.Log(parameters);
        }
    }
}
