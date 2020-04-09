//using UnityEngine;
//using System.Collections;


//public class PlayerController : MonoBehaviour
//{

	
//	private float maxSpeed = 10f;

	
//	private bool facingLeft = true;

	
//	private Rigidbody2D rb;

	
//	private Animator anim;


	
//	void Start()



//	{
//		rb = GetComponent<Rigidbody2D>();
//		anim = GetComponent<Animator>();
//	}

	
//	void FixedUpdate()
//	{

//		// Get the extent to which the player is currently pressing left or right
//		float h = Input.GetAxis("Horizontal");
//		float v = Input.GetAxis("Vertical");

//		// Move the RigidBody2D (which holds the player sprite)
//		// on the x axis based on the stae of input and the maxSpeed variable
//		rb.velocity = new Vector2(v * maxSpeed, rb.velocity.y);
//		rb.velocity = new Vector2(h * maxSpeed, rb.velocity.x);


//		// Pass in the current velocity of the RigidBody2D
//		// The speed parameter of the Animator now knows
//		// how fast the player is moving and responds accordingly
//		anim.SetFloat("speed", Mathf.Abs(rb.velocity.y));
//		anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));


//		// Check which way the player is facing 
//		// and call reverseImage if neccessary
//		if (h < 0 && !facingLeft)
//			reverseImage();
//		else if (h > 0 && facingLeft)
//			reverseImage();

//	}

//	void reverseImage()
//	{
//		// Switch the value of the Boolean
//		facingLeft = !facingLeft;

//		// Get and store the local scale of the RigidBody2D
//		Vector2 theScale = rb.transform.localScale;

//		// Flip it around the other way
//		theScale.x *= -1;
//		rb.transform.localScale = theScale;
//	}

//}