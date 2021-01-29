using System;
using System.Collections.Generic;
using System.Text;

namespace Quartz
{
    class Atom
    {
        public string Name;
        public string Symbol;
        public int Atomic;
        public int Period;
        public int Group;  // Group goes from 1-18
        public float ElectroNegativity;
        private int? valenceElectrons;
        public Constants.Type AtomType;
        
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
