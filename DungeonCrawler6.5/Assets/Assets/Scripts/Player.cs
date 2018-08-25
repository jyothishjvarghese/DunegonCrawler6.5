using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    protected float speed;
    [SerializeField]
    protected float jumpForce;

    protected Rigidbody2D _rigid;
    protected PlayerAnimation _anim;
    
	// Use this for initialization
	void Start ()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponent<PlayerAnimation>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float move = Input.GetAxis("Horizontal");
        _rigid.velocity = new Vector2(move * speed, _rigid.velocity.y);
	}
}
