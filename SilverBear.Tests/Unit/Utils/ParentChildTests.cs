using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilverBear.WebMVC.Utils;
using Xunit;

namespace SilverBear.Tests.Unit.Utils
{
    public class ParentChildTests
    {

        public ParentChildTests()
        {

        }

        [Fact]
        public void ShouldTestParentChild()
        {
            // Given
            var p = new Parent();
            Parent c = new ParentChild();
            ParentChild c1 = new ParentChild();

            // When
            p.Foo();
            p.Bar();
            c.Foo();
            c.Bar();
            c1.Foo();
            c1.Bar();

            // Then


        }

    }
}
