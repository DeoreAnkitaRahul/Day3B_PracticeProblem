﻿using static Day3B_PracticeProblem.ConstructorTypes;

namespace Day3B_PracticeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConstructorTypes constructor = new ConstructorTypes();
            ConstructorTypes types = new ConstructorTypes(345, "Ankita");
            ConstructorTypes copy = new ConstructorTypes(types);
        }
    }
}
