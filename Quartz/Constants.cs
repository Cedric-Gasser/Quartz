using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Quartz
{
    public static class Constants
    {
        public enum Type
        {
            Metal,
            Metalloid,
            Nonmetal,
            Unknown
        }
        
        public static Dictionary<string, Atom> Atoms = new Dictionary<string, Atom>()
        {
            {"Hydrogen", new Atom("Hydrogen", "H", 1, 1, 1, 2.2, Type.Nonmetal)},
            {"Helium", new Atom("Helium", "He", 2, 1, 8, null, Type.Nonmetal)},
            {"Lithium", new Atom("Lithium", "Li", 3, 2, 1, 0.98, Type.Metal)}
        };
    }
}