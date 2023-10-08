using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Albatros : Luft
{
    private int Health;
    private int Legs;
    private int Speed;
    Albatros Albatros1 = new Albatros(25, 100, 2);

    public Albatros(int AnimalHealth, int AnimalSpeed, int LegAmount)
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
