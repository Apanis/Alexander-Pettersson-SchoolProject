using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lax : Vatten
{
    public override void SetHealth()
    {
        this.SetHealth(10);
    }
    public override void SetSpeed()
    {
        this.SetSpeed(60);
    }
    public override void SetLegAmount()
    {
        this.SetLegAmount(0);
    }
    
}
