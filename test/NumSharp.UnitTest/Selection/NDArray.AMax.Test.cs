﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSharp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumSharp.UnitTest.Selection
{
    [TestClass]
    public class NDArrayAMaxTest
    {
        
        [TestMethod]
        public void amax()
        {
            //no axis
            var n = np.arange(4).reshape(2, 2);
            var n1 = np.amax(n).MakeGeneric<double>();
            Assert.IsTrue(n1[0] == 3);

            //2D with axis
            n1 = np.amax(n, 0).MakeGeneric<double>();
            Assert.IsTrue(n1[0] == 2);
            Assert.IsTrue(n1[1] == 3);
            n1 = np.amax(n, 1).MakeGeneric<double>();
            Assert.IsTrue(n1[0] == 1);
            Assert.IsTrue(n1[1] == 3);

            //3D
            n = np.arange(24).reshape(4, 3, 2);
            n1 = np.amax(n, 0).MakeGeneric<double>();
            Assert.IsTrue(n1[0, 1] == 19);
            Assert.IsTrue(n1[2, 1] == 23);
            Assert.IsTrue(n1[1, 1] == 21);
            n1 = np.amax(n, 1).MakeGeneric<double>();
            Assert.IsTrue(n1[1, 1] == 11);
            Assert.IsTrue(n1[2, 1] == 17);
            Assert.IsTrue(n1[3, 0] == 22);

            //4D
            n = np.arange(24).reshape(2, 3, 2, 2);
            n1 = np.amax(n, 1).MakeGeneric<double>();
            Assert.IsTrue(n1[0, 0, 1] == 9);
            Assert.IsTrue(n1[1, 0, 1] == 21);
            Assert.IsTrue(n1[1, 1, 1] == 23);
            n1 = np.amax(n, 3).MakeGeneric<double>();
            Assert.IsTrue(n1[0, 1, 1] == 7);
            Assert.IsTrue(n1[1, 1, 1] == 19);
            Assert.IsTrue(n1[1, 2, 1] == 23);
        }
        
    }
}
