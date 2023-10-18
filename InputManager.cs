namespace Calculatrice;

public class InputManager
{
    public Historique Historique { get; set; } = new Historique();

    // Récupération des valeurs de chaques input
    public int GetNumberInputLoop(string label)
    {
        int? a = null;
        do
        {
            Console.WriteLine("Veuillez saisir la valeur de  " + label +" :");
            a = GetNumberInput();
        } while (a == null);

        Historique.Add(a.ToString());
        return a.Value;
    }

    // Vérifie si l'input est un entier
    public static int? GetNumberInput()
    {
        var canParse = int.TryParse(Console.ReadLine(), out var result);
        if (!canParse)
        {
            Console.WriteLine("La valeur saisie n'est pas un entier");
            return null;
        }
        return result;
    }

    // gestion des opérateurs
    public string GetOperator()
    {
        string input;
        List<string> operators = new List<string>()
        {
            "+", "-", "*", "/", "%"
        };
        Console.WriteLine($"Veuillez saisir l'opérateur ({String.Join(",", operators)}) :");

        do
        {
            input = Console.ReadLine();
            if (!operators.Contains(input))
            {
                Console.WriteLine($"Opérateur invalide ({String.Join(",", operators)})");
            }
        } while (!operators.Contains(input));
        Historique.Add(input);
        return input;
    }
}