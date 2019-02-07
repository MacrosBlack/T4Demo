using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;
using T4DemoModel;

[TestClass]
public class DebugTest
{
    [TestMethod]
    [DeploymentItem("TestScenarios.json")]
    public void TestMethod()
    {
        var testContent = File.ReadAllText("TestScenarios.json");
        var tests = JsonConvert.DeserializeObject<ModelScenario[]>(testContent);
        Assert.IsTrue(tests.Length > 1);
    }
}
