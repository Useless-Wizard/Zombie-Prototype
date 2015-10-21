﻿using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public GameObject bullet;
	public GameObject owner;
	public int damage = 0;
	public float knockback = 0.0f;
	public GameObject victim;  // this is only not null if the event actually hit something
	public bool ranged = false;

	public Attack(GameObject owner, int damage, float knockback)
	{
		this.owner = owner;
		this.damage = damage;
		this.knockback = knockback;
	}

	static public int CalculateDamage(int damage, int armor)
	{
		int total = 0;

		if(damage > 0) 
		{
			total = Mathf.Max(1, damage - Mathf.Max(0, armor) );
		}

		return total;
	}
}