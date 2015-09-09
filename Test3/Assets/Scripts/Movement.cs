﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;

	Animator animator;
	private bool walking = false;
	private bool kicking = false;

	private string currentDirection = "right";

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		animator = this.GetComponentInChildren<Animator>();
	}
	
	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.Space))
		{
			kicking = true;
			animator.SetBool ("kicking", kicking);
		}
		else if (Input.GetKey ("right") || Input.GetKey ("left") || Input.GetKey ("up") || Input.GetKey ("down"))
		{
			if (Input.GetKey ("right"))
			{
				this.changeDirection("right");
			}
			if (Input.GetKey ("left"))
			{
				this.changeDirection("left");
			}
			walking = true;
			animator.SetBool ("walking", walking);
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
			
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			
			rb.AddForce (movement * speed);
		}

		else
		{
			walking = false;
			animator.SetBool ("kicking", false);
			animator.SetBool ("walking", walking);
		}

	}

	//--------------------------------------
	// Flip player sprite for left/right walking
	//--------------------------------------
	void changeDirection(string direction)
	{
		if (currentDirection != direction)
		{
			if (direction == "right")
			{
				transform.Rotate (0, 180, 0);
				currentDirection = "right";
			}
			else if (direction == "left")
			{
				transform.Rotate (0, -180, 0);
				currentDirection = "left";
			}
		}
	}
}