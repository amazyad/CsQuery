﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using NUnit.Framework;
using Jtc.CsQuery;

namespace CsqueryTests
{

    [TestFixture, Description("CsQuery Core Tests ")]
    public class CsQueryCoreTest
    {
        protected CsQuery csq;

        [Test]
        public void TestExtensionMethods()
        {
            int x = 1;
            string a = "hello";
            object test = null;
            object test2 = new List<string>();
            object exp = new ExpandoObject();
            KeyValuePair<string, string> kvp = new KeyValuePair<string, string>("somekey", "somevalue");

            NUnit.Framework.Assert.IsTrue(x.IsImmutable(), "integer is immutable type");
            Assert.IsTrue(a.IsImmutable(), "string is immutable type");
            Assert.IsTrue(test.IsImmutable(), "null is immutable type");
            Assert.IsTrue(!test2.IsImmutable(), "List is not immutable type");
            Assert.IsTrue(!kvp.IsImmutable(), "KVP is not immutable type");
            Assert.IsTrue(!kvp.IsExpando(), "KVP is not expando");
            Assert.IsTrue(exp.IsExpando(), "expando object is expando");

            Assert.IsTrue(!x.IsExtendableType(), "int is not extendable");
            Assert.IsTrue(!a.IsExtendableType(), "string is not extendable");
            Assert.IsTrue(!test.IsExtendableType(), "null is not extendable");
            Assert.IsTrue(exp.IsExtendableType(), "expando object is extendable");
            Assert.IsTrue(kvp.IsExtendableType(), "kvp is extendable");

        }

      
    }
}