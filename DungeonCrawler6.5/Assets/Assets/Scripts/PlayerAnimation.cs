using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    protected Animator _anim;

	void Start ()
    {
        _anim = GetComponentInChildren<Animator>();
	}
	
    public void Run()
    {

    }
	
}
