namespace CalcLibTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int Testnum1 = 2;
        int Testnum2 = 3;
        int sum = Testnum1 + Testnum2;
        int result = CalculatorLibrary.CalculatorLibrary.Add(Testnum1,Testnum2);
        Assert.AreEqual(result,sum);
    }
}