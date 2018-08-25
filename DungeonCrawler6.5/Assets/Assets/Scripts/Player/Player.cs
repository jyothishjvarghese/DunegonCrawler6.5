using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    protected float speed;
    [SerializeField]
    protected float jumpForce;
    [SerializeField]
    private bool isGrounded;

    private bool resetJump;

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
        Movement();
        if(Input.GetKeyDown(KeyCode.L) && isGrounded == true)
        {
            _anim.Attack();
        }
        
	}
    public void Movement()
    {
        float move = Input.GetAxis("Horizontal");
        _rigid.velocity = new Vector2(move * speed, _rigid.velocity.y);
        _anim.Run(move);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.down, 0.8f, 1 << 8);
        Debug.DrawRay(transform.position, Vector2.down * 0.8f, Color.green);

        if(hitInfo.collider != null)
        {
            if (resetJump == false)
            {
                isGrounded = true;
                if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
                {
                    _rigid.velocity = new Vector2(move * speed, jumpForce);
                    _anim.Jump();
                    isGrounded = false;
                    resetJump = true;
                    StartCoroutine(ResetJumpNeededRoutine());
                }
            }
        }
    }
    IEnumerator ResetJumpNeededRoutine()
    {
        yield return new WaitForSeconds(0.1f);
        resetJump = false;
    }
}
