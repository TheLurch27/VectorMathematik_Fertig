using System.Numerics;

namespace VectorMathematik_Fertig
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, y1, z1, x2, y2, z2;

            while (true)
            {
                // Hier muss der Nutzer 3 Ziffern für den ersten Vetor eingeben (x, y und z)
                Console.WriteLine("Enter the Numbers for the first vector (x y z) - (separate the 3 numbers with a space (example: 1 2 3)):");
                string[] input1 = Console.ReadLine().Split(); // .Split() sorgt dafür das die Zahlen zwischen den Leerzeichen erkannt werden
                if (input1.Length != 3 || !float.TryParse(input1[0], out x1) || !float.TryParse(input1[1], out y1) || !float.TryParse(input1[2], out z1))
                // input1.Length != 3 (Überprüft ob die Eingabe aus 3 Zahlen oder Zeichen besteht), !float.TryParse(input1[0], out x1) (parsed das erste Zeichen in einen float wert (x1))
                // "!" negativiert es um feststellen zu können ob das parsen erfolgreich war. (das selbe passiert mit y1 und z1)
                {
                    Console.WriteLine("Invalid input. Please enter three numbers for the coordinates."); // Ist der eingabewert falsch eingegeben worden wird eine Fehlermeldung angezeigt und auf wiederholung bestanden!!!!!
                    continue;
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                // Naja hier für den zweiten... is ja logisch ^^
                Console.WriteLine("Enter the Numbers for the second vector (x y z) - (separate the 3 numbers with a space (example: 1 2 3)):");
                string[] input2 = Console.ReadLine().Split();
                if (input2.Length != 3 || !float.TryParse(input2[0], out x2) || !float.TryParse(input2[1], out y2) || !float.TryParse(input2[2], out z2))
                // NEIN ICH WERDE DEN ROMAN DA OBEN NICHT NOCHMAL HIER HINSCHREIBEN! SIEH EINFACH ZEILE 15 und 16 und tausche x1 mit x2 und so weiter...
                {
                    Console.WriteLine("Invalid input. Please enter three numbers for the Vectors."); // Auch hier... siehe Zeile 18
                    continue;
                }
                else
                {
                    break;
                }

            }

            Vector v1 = new Vector(x1, y1, z1); // Hier wird der erste Vektor mit den eingegebenen Zahlen erstellt.
            Vector v2 = new Vector(x2, y2, z2); // Schau gern eine Zeile drüber...

            // Grundschul Wissen
            Vector sum = v1 + v2; // Plus Rechnung (Summe)
            Vector difference = v1 - v2; // Minus Rechnung (Differenz)
            Vector scaled = v1 * 2; // Mal Rechnung (Skalierung des ersten Vektors um den Faktor 2)
            Vector quotient = v1 / v2; // Geteilt Rechnung (Quotient des ersten Vektors durch den zweiten Vektor)

            float distance = v1.Distance(v2); // Hier wird die Distanz der beiden Vektoren berechnet.
            float staticDistance = Vector.StaticDistance(v1, v2); // Statische Methode zur Berechnung der Distanz zwischen den beiden Vektoren.

            float magnitude = v1.Magnitude(); // Hier wird die Länge des ersten Vektors berechnet
            float squaredMagnitude = v1.SquaredMagnitude(); // und die Quadratlänge des ersten Vektors

            // Hier gibts die Ausgabe des ganzen Bumms
            Console.WriteLine($"Sum: ({sum.x}, {sum.y}, {sum.z})");
            Console.WriteLine($"Difference: ({difference.x}, {difference.y}, {difference.z})");
            Console.WriteLine($"Scaled: ({scaled.x}, {scaled.y}, {scaled.z})");
            Console.WriteLine($"Divided: ({quotient.x}, {quotient.y}, {quotient.z})");

            Console.WriteLine($"Distance: {distance}");
            Console.WriteLine($"Static Distance: {staticDistance}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MATHE IST EIN ARSCHLOCH");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Magnitude: {magnitude}");
            Console.WriteLine($"Squared Magnitude: {squaredMagnitude}");
        }
    }
}
