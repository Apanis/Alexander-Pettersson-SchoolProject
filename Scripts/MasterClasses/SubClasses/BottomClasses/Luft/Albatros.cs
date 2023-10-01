using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Albatros : Luft
{
    public override void SetHealth()
    {
        this.SetHealth(25);
    }
    public override void SetSpeed()
    {
        this.SetSpeed(100); 
    }
    public override void SetLegAmount()
    {
        this.SetLegAmount(2);
    }
}
