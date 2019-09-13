using AceDriveWeb.Client.Controllers;
using Xunit;

namespace AceDriveWeb.Tests {
  public class UnitTestA {
    ValuesController controller = new ValuesController();
    [Fact]
    public void Get_Returns_My_Name() {
      var returnValue = controller.Get(1);
      Assert.Equal("Alex Nyamweya", returnValue.Value);
    }  
  }    
}