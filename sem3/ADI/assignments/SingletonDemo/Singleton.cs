using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private Singleton() { }
        public static readonly Singleton _instance = new Singleton();
        private int count = 0;
        public void increase() => count++;
        public int Count => count;

    }
}
