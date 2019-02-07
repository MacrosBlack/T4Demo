using Newtonsoft.Json;
using System.Collections.Generic;
using T4DemoModel;

namespace T4Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new List<ModelScenario>();
            var startScenario = new ModelScenario();
            startScenario.TestName = "OpenGenieTest";
            startScenario.TestStepName = new string[] { "OpenNoahStep", "StartGenieStep" };
            tests.Add(startScenario);

            var closeScenario = new ModelScenario();
            startScenario.TestName = "CloseGenieTest";
            startScenario.TestStepName = new string[] { "FindGenieStep", "CloseGenieStep" };
            tests.Add(startScenario);

            var content = JsonConvert.SerializeObject(tests);
            var scenarios = JsonConvert.DeserializeObject<ModelScenario[]>(content);
        }
    }
}
