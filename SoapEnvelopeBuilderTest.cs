using System;
using System.Diagnostics;
using Xunit;

namespace Soap.Test
{
    public class SoapEnvelopeBuilderTest
    {
        [Fact]
        public void CanCreate()
        {
            var envelope = new SoapEnvelopeBuilder()
                .InCodeunit("SrvLeasingItemMgt")
                    .CallMethod("UpdateLiquidityLevel")
                        .WithParameter("updateLiquidityLevelRq", Base64.Encode("8hi7ttfjtgbh"))
                .Envelope();
                //.Send("http://xxxxxxxxx/Service1.asmx",
                //      "http://xxxxxxxx/Service1.asmx?op=HelloWorld");
            Debug.WriteLine(envelope);
        }
    }
}
