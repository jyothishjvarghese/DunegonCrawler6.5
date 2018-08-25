using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mossgiant : Enemy, IDamagable
{
    public int Health { get; set; }
    
	
	
	// Update is called once per frame
	public override void Init ()
    {
        base.Init();
        Health = base.health;
	}
    public void Damage()
    {
        Debug.Log("Damage");
        //Health--;
        anim.SetTrigger("Hit");
    }
}
