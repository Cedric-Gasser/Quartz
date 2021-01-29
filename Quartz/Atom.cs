using System;
using System.Collections.Generic;
using System.Text;

namespace Quartz
{
    public class Atom
    {
        public string Name;
        public string Symbol;
        public int Atomic;
        public int Period;
        public int Group;  // Group goes from 1-18
        public double? ElectroNegativity;
        private int? valenceElectrons;
        public Constants.Type AtomType;

        public Atom(string name, string symbol, int atomic, int period, int group, double? electroNegativity, Constants.Type atomType)
        {
            Name = name;
            Symbol = symbol;
            Atomic = atomic;
            Period = period;
            Group = group;
            ElectroNegativity = electroNegativity;
            AtomType = atomType;
        }
        
        public bool IsMainGroup => Group <= 2 && Group >= 13;
        public int? ValenceElectrons { 
            get{
                if ( !IsMainGroup) {
                    return null;   
                }
                return Group <= 2 ? Group : Group - 10;
            } 
            set => valenceElectrons = value; 
        }

    }
}
