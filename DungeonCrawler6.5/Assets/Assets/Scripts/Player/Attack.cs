using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    // Use this for initialization
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.collider != null)
        Debug.Log("Hit" + gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
