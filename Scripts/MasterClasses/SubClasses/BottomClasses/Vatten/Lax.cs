using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lax : Vatten
{
    private int Health;
    private int Legs;
    private int Speed;
    Lax lax1 = new Lax(10, 60, 0);

    public Lax(int AnimalHealth, int AnimalSpeed, int LegAmount)
    {
        Health = AnimalHealth;
        Speed = AnimalSpeed;
        Legs = LegAmount;
    }
    public override void SetHealth()
    {
        this.SetHealth(Health);
    }
    public override void SetSpeed()
    {
        this.SetSpeed(Speed);
    }
    public override void SetLegAmount()
    {
        this.SetLegAmount(Legs);
    }

}
