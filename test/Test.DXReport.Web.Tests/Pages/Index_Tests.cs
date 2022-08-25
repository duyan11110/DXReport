using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Test.DXReport.Pages;

public class Index_Tests : DXReportWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
