namespace DefaultNamespace;

public class Type
{
    private string Name { get; set; }

    public Type(string name)
    {
        this.Name = name;
    }

    public float AttackEffectivity(Attack attack, Type type)
    {
        if (attack.Atype == Water)
        {
            if (type == Fire)
            {
                attack.damage = attack.damage * 2;
            }
            if (type == Grass)
            {
                attack.damage = attack.damage / 2;
            }
        }
        
        if (attack.Atype == Fire)
        {
            if (type == Grass)
            {
                attack.damage = attack.damage * 2;
            }
            if (type == Water)
            {
                attack.damage = attack.damage / 2;
            }
        }
        
        if (attack.Atype == Grass)
        {
            if (type == Water)
            {
                attack.damage = attack.damage * 2;
            }
            if (type == Fire)
            {
                attack.damage = attack.damage / 2;
            }
        }

        return attack.damage;
    }
}