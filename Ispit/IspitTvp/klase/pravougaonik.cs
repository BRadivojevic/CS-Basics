using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace klase
{
    class pravougaonik
    {
        public float x;
        public float y;

        public pravougaonik(float sirina, float visina)
        {
            x = sirina;
            y = visina;
        }
        public float izracunaj()
        {
            float broj1;
            broj1 = Math.Abs(x * y);
            return broj1;
        }
        public pravougaonik(SerializationInfo info, StreamingContext context)
        {
            x = info.GetInt32("sirina");
            y = info.GetInt32("visina");
            
        }

        public bool Upisan()
        {
            return true;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("sirina", x);
            info.AddValue("visina", y);

            info.AddValue("upisan", Upisan());
        }

        public override string ToString()
        {
            return x + " " + y;
        }
    } 
}
