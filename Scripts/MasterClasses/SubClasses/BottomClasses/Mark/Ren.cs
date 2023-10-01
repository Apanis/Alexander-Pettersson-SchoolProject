using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ren : Mark
{
    public override void SetHealth()
    {
        this.SetHealth(50);
    }
    public override void SetSpeed()
    {
        this.SetSpeed(75);
    }
    public override void SetLegAmount()
    {
        this.SetLegAmount(4);
    }
}
