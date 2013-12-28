using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        public const string DEFAULT_VALUE = "TEST";
        public string Property1 { get { return _field1; } }
        private string _field1;

        private void ResetProperty1()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            ResetProperty1();
        }
    }
}
