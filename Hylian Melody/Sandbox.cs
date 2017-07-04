using System;
using HylianMelody.NSPC;

namespace HylianMelody
{
    class Sandbox
    {
        public void Test()
        {
            Type foo = typeof(Track);

            object baz = new Track();
            Type bar = baz.GetType();
        }
    }
}
