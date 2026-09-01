
compteBancaire Bob = new compteBancaire("Bob", 100.00f, a);
exempleClass2 a = new exempleClass2();
Console.WriteLine(Bob);

public class compteBancaire
{
    // set; ou private_set ou ___
    public string Nom { get; }
    public float Argent { get; set; }
    public exempleClass2 euuuh { get; set; }

    // +----- Constructeur -----+
    public compteBancaire(string nom, float argent, exempleClass2 euuuh)
    {
        Nom = nom;
        Argent = argent;
        euuuh = euuuh;
    }

    // +----- Méthodes -----+
    public void ExempleMethode(int nombres = 1)
    {
        Argent += nombres;
    }

    // Remplace Console.Writeline
    public override string ToString()
    {
        return $"nom = {Nom}\nArgent = {Argent}";
    }
}

public class exempleClass2
{

}