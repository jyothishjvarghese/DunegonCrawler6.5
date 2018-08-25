using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected Animator anim;
    protected SpriteRenderer sprite;

    [SerializeField]
    protected Transform pointA, pointB;

    private bool _switch;
    private float speed = 1.0f;
	

    public virtual void Init()
    {
        anim = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
	void Start ()
    {
        Init();
	}
	
	// Update is called once per frame
	public virtual void Update ()
    {

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            return;
        }
        Movement();
    }
    public virtual void Movement()
    {
        if(transform.position == pointA.position)
        {
            _switch = true;
            anim.SetTrigger("Idle");
            sprite.flipX = false;

        }
        else if(transform.position == pointB.position)
        {
            _switch = false;
            anim.SetTrigger("Idle");
            sprite.flipX = true;
        }
        if(_switch == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
        }
        if(_switch == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);
        }
    }
    public virtual void Attack()
    {

    }
}
