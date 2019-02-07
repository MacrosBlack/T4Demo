using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
[DeploymentItem("TestScenarios.json")]
public class ScenariosTest:TestBase
{
    [TestMethod]
    public void StartGenieTest()
    {
		Assert.IsTrue(OpenNoahStep());
		Assert.IsTrue(FindGenieStep());
		Assert.IsTrue(ClickGenieBtnStep());
		}

    [TestMethod]
    public void CloseGenieTest()
    {
		Assert.IsTrue(FindGenieStep());
		Assert.IsTrue(CloseGenieStep());
		}

    [TestMethod]
    public void OpenClient()
    {
		Assert.IsTrue(FindGenieStep());
		Assert.IsTrue(OpenClientStep());
		}

}
