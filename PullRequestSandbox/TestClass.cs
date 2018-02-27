using System;

namespace InlineComments
{
    class TestClass
    {
        public int PropertyWithComment1 { get; set; }
        public int Property1 { get; }
        public int PropertyWithComment2 { get; set; }
        public int Property2 { get; }

        public void MethodWithComment2()
        {
            // MethodWithComment2 method contents.
        }

        public void Method1()
        {
            // Method1 method contents..
        }

        public void AnotherMethod()
        {
            // Hard breakfast
        }
    }
}