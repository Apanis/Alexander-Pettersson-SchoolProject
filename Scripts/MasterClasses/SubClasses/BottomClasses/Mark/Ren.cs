using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ren : Mark
{
    private int Health;
    private int Legs;
    private int Speed;
    Ren Ren1 = new Ren(50, 75, 4);

    public Ren(int AnimalHealth, int AnimalSpeed, int LegAmount)
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
