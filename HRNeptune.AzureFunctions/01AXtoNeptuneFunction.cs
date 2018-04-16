using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using nVisionIT.MIT.Common.Logging;
using Omnia.Core.Logging;

namespace Omnia.Templates
{
    public static class AXtoNeptuneFunction
    {
        [FunctionName("TimerFunction")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            ILogger logger = new MockLogger();
            HRNeptuneController timerController = new HRNeptuneController(logger);
            timerController.Run(1, "Test");
        }
    }
}
