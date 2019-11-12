using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MyPlayerTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        [Category("PlayerCategory")]
        public void MyPlayerTestScriptSimplePasses()
        {
            var player = GameObject.FindGameObjectWithTag("Player");

            Assert.IsNotNull(player);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator MyPlayerTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
