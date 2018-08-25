using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy, IDamagable
{
    public int Health { get; set; }

    public void Damage() { }

    public override void Init()
    {
        base.Init();
        
    }

}
