namespace T4DemoModel
{
    public class Model
    {
        public ModelScenario[] TestScenarios;

        public Model()
        {
            TestScenarios = new[] {
                new ModelScenario() { TestName = "OpenNoahTest", TestStepName = new[] { "OpenNoahStep", "FindDemoApplicationStep", "ClickDemoApplicationBtnStep" } },
                new ModelScenario() { TestName = "CloseDemoApplicationTest", TestStepName = new[] { "FindDemoApplicationStep", "CloseDemoApplicationStep" } },
                new ModelScenario() { TestName = "OpenClientTest", TestStepName = new[] { "FindDemoApplicationStep", "OpenClientStep" } },
                new ModelScenario() { TestName = "GertTest", TestStepName = new[] { "FindDemoApplicationStep", "OpenClientStep" } },
            };
        }
    }
}
