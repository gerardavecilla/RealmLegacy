using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet02 : MonoBehaviour {
	float bulletSpeed = 15.0f;
	Rigidbody2D rbd;
	// Use this for initialization
	void Start () {
		rbd = gameObject.GetComponent<Rigidbody2D>();
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Pitfall01").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Pitfall02").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Pitfall03").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Pitfall04").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Pitfall05").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Player").GetComponent<Collider2D>(), true);
	}

	// Update is called once per frame
	void Update () {
		Vector2 forwards = gameObject.transform.up;
		gameObject.transform.Translate(forwards * Time.deltaTime * bulletSpeed, Space.World);
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			GameObject.Destroy(gameObject);
		}
		else if (col.gameObject.tag == "LevelBounds")
		{
			GameObject.Destroy(gameObject);
		}
	}
}
