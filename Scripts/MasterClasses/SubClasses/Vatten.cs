using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vatten : Djur
{
    private int Speed;
    private int Health;
    private int AmountOfLegs;
    public void SetHealth(int health)
    { this.Speed = health; }

    public void SetSpeed(int speed)
    { this.Speed = speed; }

    public void SetLegAmount(int amount)
    {
        this.AmountOfLegs = amount;
    }
    public int GetHealth()
    {
        return Health;
    }
    public int GetSpeed()
    {
        return Speed;
    }

}
