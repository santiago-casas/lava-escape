using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
	public float runSpeed=2;
	public float jumpSpeed=3;
	Rigidbody2D rb2D;
	public bool betterJump = false;

	public float fallMultiplayer = 0.5f;
	public float lowjumpMultiplayer = 1f;


	void Start(){
			rb2D = GetComponent<Rigidbody2D>();
	}
	public SpriteRenderer spriteRenderer;
	public Animator animator;

	void FixedUpdate()
	{
		if (Input.GetKey("d"))
		{
			rb2D.velocity=new Vector2(runSpeed, rb2D.velocity.y);
			spriteRenderer.flipX=false;
			animator.SetBool("Run", true);
		}
		else if(Input.GetKey("a"))
		{
			rb2D.velocity=new Vector2(-runSpeed, rb2D.velocity.y);
			spriteRenderer.flipX=true;
			animator.SetBool("Run", true);
		}
		else
		{
			rb2D.velocity=new Vector2(0, rb2D.velocity.y);
			animator.SetBool("Run", false);
		}
		if(Input.GetKey("w") && groundChecker.isGrounded)
		{
			rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
		}
		if(groundChecker.isGrounded==false){
			animator.SetBool("jump", true);
			animator.SetBool("Run", false);
		}
		if(groundChecker.isGrounded==true){
			animator.SetBool("jump", false);
			
		}		
		if(betterJump){
			if(rb2D.velocity.y<0){
				rb2D.velocity +=Vector2.up*Physics2D.gravity.y*(fallMultiplayer)*Time.deltaTime;

			}
			if(rb2D.velocity.y>0 && !Input.GetKey("w")){
				rb2D.velocity +=Vector2.up*Physics2D.gravity.y*(lowjumpMultiplayer)*Time.deltaTime;
			}
		}
	}
}