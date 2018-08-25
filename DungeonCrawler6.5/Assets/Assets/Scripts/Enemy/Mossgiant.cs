using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mossgiant : Enemy, IDamagable
{
    public int Health { get; set; }
    public void Damage() { }
	
	
	// Update is called once per frame
	public override void Init ()
    {
        base.Init();
	}
}
