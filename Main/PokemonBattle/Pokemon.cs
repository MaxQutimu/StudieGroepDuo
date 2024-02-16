using System;

public enum PokemonType
{
    Water,
    Grass,
    Fire,
}

public enum Strength
{
    Fire,
    Water,
    Grass,
}

public enum Weakness
{
    Fire,
    Grass,
    Water,
}

public abstract class Pokemon
{
    private string _name;
    private string _nickname;
    private PokemonType _type;
    private Strength _strength;
    private Weakness _weakness;

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public string Nickname
    {
        get { return _nickname; }
        private set { _nickname = value; }
    }

    public PokemonType Type
    {
        get { return _type; }
        private set { _type = value; }
    }

    public Strength Strength
    {
        get { return _strength; }
        private set { _strength = value; }
    }

    public Weakness Weakness
    {
        get { return _weakness; }
        private set { _weakness = value; }
    }

    protected Pokemon(string name, string nickname, PokemonType type, Strength strength, Weakness weakness)
    {
        Name = name;
        Nickname = nickname;
        Type = type;
        Strength = strength;
        Weakness = weakness;
    }

    public abstract string BattleCry();

    // Method to display Pokemon information
    protected void DisplayPokemonInfo()
    {
        Console.WriteLine($"Pokemon Name: {_name}");
        Console.WriteLine($"   Pokemon Type: {_type}");
        Console.WriteLine($"   Pokemon Strength: {_strength}");
        Console.WriteLine($"   Pokemon Weakness: {_weakness}");
    }

    // Method to choose player's Pokemon name
    protected void ChooseName()
    {
        Console.WriteLine("Choose a name for your Pokemon");
        while (true)
        {
            string chosenName = Console.ReadLine();
            Console.WriteLine($"You chose a name for your Pokemon: {chosenName}");
            Console.WriteLine($"Are you sure you want your Pokemon to be named: {chosenName} (Yes/No)");
            string choiceConfirmation = Console.ReadLine().ToLower();

            if (choiceConfirmation == "yes")
            {
                Nickname = chosenName;
                break;
            }
            else if (choiceConfirmation == "no")
            {
                Console.WriteLine("Choose a name for your Pokemon");
            }
            else
            {
                Console.WriteLine("Error, try again");
            }
        }
    }
}

public sealed class Squirtle : Pokemon
{
    public Squirtle(string nickname) : base("Squirtle", nickname, PokemonType.Water, Strength.Water, Weakness.Grass)
    {
    }

    public override string BattleCry()
    {
        return $"{Name} Uses Battle cry: {Nickname}";
    }
}

public sealed class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickname) : base("Bulbasaur", nickname, PokemonType.Grass, Strength.Grass, Weakness.Fire)
    {
    }

    public override string BattleCry()
    {
        return $"{Name} Uses Battle cry: {Nickname}";
    }
}

public sealed class Charmander : Pokemon
{
    public Charmander(string nickname) : base("Charmander", nickname, PokemonType.Fire, Strength.Fire, Weakness.Water)
    {
    }

    public override string BattleCry()
    {
        return $"{Name} Uses Battle cry: {Nickname}";
    }
}
