namespace OrdenacaoTest;
using OrdenacaoAPI.Models;

[TestClass]
public class NumbersOrderstest
{
    [TestMethod]
    public void ChangeTest()
    {
        int[] expected =new int[] {4,6};
        int[] result;

        NumbersOrders numbers = new NumbersOrders();
        result = numbers.Change(6,4);

        CollectionAssert.AreEqual(expected, result);


    }

     [TestMethod]
    public void ChangeNegativeTest()
    {
        int expected = -6;
        int result;

        NumbersOrders numbers = new NumbersOrders();
        result = numbers.ChangeNegative(6);

        Assert.AreEqual(expected, result);


    }
}