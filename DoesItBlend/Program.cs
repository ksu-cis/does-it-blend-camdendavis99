using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> blendables = new List<IBlendable>();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());

            string mess = "";
            foreach(dynamic blendable in blendables)
            {
                mess += blendable.Blend();
            }
            Console.WriteLine(mess);
        }
    }
}
