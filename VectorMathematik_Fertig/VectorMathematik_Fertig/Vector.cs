using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMathematik_Fertig
{
    public class Vector
    {
        // Vektoren
        public float x;
        public float y;
        public float z;

        // Standardkonstruktor
        public Vector()
        {
            // Hier werden die Komponente auf 0 gesetzt.
            x = 0;
            y = 0;
            z = 0;
        }

        // Einen Konstruktor mit Parametern initialisiert (Mathe is immernoch doof)
        public Vector(float x, float y, float z)
        {
            // Hier werden die Werte in die Komponente übergeben
            this.x = x; // this.x (Bezieht sich auf das x Attribut)
            this.y = y; // Siehe Zeile 29 (nur auf y bezogen)
            this.z = z; // Siehe Zeile 29 (nur auf z bezogen)
        }

        // (Plus) Operator 
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z); // Es wird ein neuer Vektor durch die Addition erzeugt
        }

        // (Minus) Operator
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z); // Hier durch die Subtraktion
        }

        // (Mal) Operator
        public static Vector operator *(Vector v, float scalar)
        {
            return new Vector(v.x * scalar, v.y * scalar, v.z * scalar); // durch Multiplikation
        }

        // (Geteilt) Operator
        public static Vector operator /(Vector v1, Vector v2)
        {
            return new Vector(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z); // teilt jede Komponente des ersten Vektors durch den zweiten Vektor
        }

        // Methode für die Distanz zwischen zwei Vektoren und der float rückgabe
        public float Distance(Vector other)
        {
            float dx = other.x - x; // die Differenz von X Komponenten der Vektoren
            float dy = other.y - y;
            float dz = other.z - z;
            return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz); // Berechnung der Distanz zwischen den Vektoren
        }

        // Implementierung in eine statische Distanz
        public static float StaticDistance(Vector v1, Vector v2)
        {
            float dx = v2.x - v1.x; // die Differenz von X Komponenten der Vektoren
            float dy = v2.y - v1.y;
            float dz = v2.z - v1.z;
            return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz); // Berechnung der Distanz zwischen den Vektoren
        }

        // Methode für die Länge eines Vektors und float ausgabe
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z); // Berechnung der Länge vom Vektors
        }

        // Methode der Quadratlänge eines Vektors und auch hier die float ausgibt
        public float SquaredMagnitude()
        {
            return x * x + y * y + z * z; // Berechnung von Quadratlänge des Vektors
        }
    }
}
