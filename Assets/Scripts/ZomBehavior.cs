using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomBehavior : MonoBehaviour {
	Rigidbody2D rbd;
	int health;
	// Use this for initialization
	void Start () {
		rbd = gameObject.GetComponent<Rigidbody2D>();
		health = 4;
	}

	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "PlayerAttack")
		{
			--health;
		}
		/* else if(col.gameObject.tag == "Player")
        {

        }*/
		if (health <= 0)
		{
			++PlayerShoot.enemiesKilled;
			GameObject.Destroy(gameObject);
		}
	}
}

