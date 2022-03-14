using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST;

public class UnitTest1
{
    ValuesController controller = new ValuesControllerContorller();
    [Fact]
    public void GetReturnsMyName()
    {
        var returnvalue = controller.Get(1);
        Assert.Equal("Rhys Brownsell", returnvalue.value);
    }


    [Fact]
    public void Test1()
    {

    }
}