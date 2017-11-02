using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 3f;
    public float JumpForce = 100f;

    public Transform GroundCheck;

    private Rigidbody2D _rigid;
    private Boolean _canJump = true;

	// Use this for initialization
	void Start ()
	{
	    _rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    RaycastHit2D raycast = Physics2D.Raycast(GroundCheck.position, Vector2.down, 0.1f);
	    if (raycast.collider != null && raycast.transform != this.transform)
	    {
	        _canJump = true;
	    }
	    else
	    {
	        _canJump = false;
	    }
	    float move = Input.GetAxis("Horizontal");

	    _rigid.velocity = new Vector2(move * Speed, _rigid.velocity.y);

	    if (_canJump && Input.GetKey(KeyCode.Space))
	    {
	        _rigid.AddForce(new Vector2(0,JumpForce),ForceMode2D.Impulse);
	    }
	}
}
