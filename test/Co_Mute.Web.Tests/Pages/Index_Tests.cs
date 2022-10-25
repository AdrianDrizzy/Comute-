using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Co_Mute.Pages;

public class Index_Tests : Co_MuteWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
