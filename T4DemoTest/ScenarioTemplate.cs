using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
[DeploymentItem("TestScenarios.json")]
public class ScenariosTest:TestBase
{
    [TestMethod]
    public void OpenNoahTest()
    {
		Assert.IsTrue(OpenNoahStep());
		Assert.IsTrue(FindApplicationStep());
		Assert.IsTrue(ClickApplicationBtnStep());
	}

    [TestMethod]
    public void CloseApplicationTest()
    {
		Assert.IsTrue(FindApplicationStep());
		Assert.IsTrue(CloseApplicationStep());
	}

    [TestMethod]
    public void OpenClientTest()
    {
		Assert.IsTrue(FindApplicationStep());
		Assert.IsTrue(OpenClientStep());
	}

    [TestMethod]
    public void GertTest()
    {
		Assert.IsTrue(FindApplicationStep());
		Assert.IsTrue(OpenClientStep());
	}

}
