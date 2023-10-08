using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public abstract class Mark : Djur
{
    private int AmountOfLegs;
    private int Speed;
    private int Health;
    public void SetHealth(int health)
    {
        this.Health = health;
    }
    public void SetSpeed(int speed)
    {
        this.Speed = speed;
    }
    public void SetLegAmount(int amount)
    {
        this.AmountOfLegs = amount;
    }
    public int GetHealth()
    {
        return this.Health;
    }
    public int GetSpeed()
    {
        return this.Speed;
    }
    public int GetLegs()
    {
        return this.AmountOfLegs;
    }

}
