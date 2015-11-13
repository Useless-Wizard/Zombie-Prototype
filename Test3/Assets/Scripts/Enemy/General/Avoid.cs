﻿using UnityEngine;
using System.Collections;

public class Avoid : MonoBehaviour
{
	BaseballWolf batwolf;
	// Use this for initialization
	void Start()
	{
		this.batwolf = this.GetComponentInParent<BaseballWolf>();
	}

	void OnTriggerEnter(Collider other)
	{
		if ((this.gameObject.tag.Equals("Player") && other.GetComponentInParent<Player>() == null)
		    || (this.gameObject.tag.Equals("Enemy") && other.GetComponentInParent<Enemy>() == null) || (this.gameObject.tag.Equals("EnemyScared") && other.GetComponentInParent<Enemy>() == null))
		{
			Vector3 distVec = (other.transform.position - transform.position);
			this.batwolf.Seek(distVec * -1);
			print("working");
		}
	}

	void OnTriggerStay(Collider other)
	{
		if ((this.gameObject.tag.Equals("Player") && other.GetComponentInParent<Player>() == null)
		    || (this.gameObject.tag.Equals("Enemy") && other.GetComponentInParent<Enemy>() == null) || (this.gameObject.tag.Equals("EnemyScared") && other.GetComponentInParent<Enemy>() == null))
		{
			Vector3 distVec = (other.transform.position - transform.position);
			this.batwolf.Seek(distVec * -1);
			print("working");
		}
	}
}
