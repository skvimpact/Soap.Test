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
            var response = new SoapEnvelopeBuilder()
                .InCodeunit("SrvLeasingItemMgt")
                    .CallMethod("UpdateLiquidityLevel")
                        .WithParameter("updateLiquidityLevelRq", value => Tools.Base64Encode("8hi7ttfjtgbh"))
                .Envelope()
                .Send("http://xxxxxxxxx/Service1.asmx",
                      "http://xxxxxxxx/Service1.asmx?op=HelloWorld");

            //envelope.Request();
//            Console.WriteLine(envelope);
            //Debug.WriteLine(envelope);
            Debug.WriteLine("That is good");
            Debug.WriteLine("That is good 2");
        }
    }
}
