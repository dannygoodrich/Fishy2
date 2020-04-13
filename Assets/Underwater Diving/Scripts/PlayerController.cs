using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour
{

	
	private float maxSpeed = 10f;

	
	private bool facingLeft = true;

	
	private Rigidbody2D rb;

	
	private Animator anim;


	
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	
	void FixedUpdate()
	{

		
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		
		rb.velocity = new Vector2(v * maxSpeed, rb.velocity.y);
		rb.velocity = new Vector2(h * maxSpeed, rb.velocity.x);


		
		anim.SetFloat("speed", Mathf.Abs(rb.velocity.y));
		anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));


		
		if (h < 0 && !facingLeft)
			reverseImage();
		else if (h > 0 && facingLeft)
			reverseImage();

	}

	void reverseImage()
	{
		
		facingLeft = !facingLeft;

		
		Vector3 theScale = rb.transform.localScale;

		// Flip it around the other way
		theScale.x *= -1;
		rb.transform.localScale = theScale;
	}

}