using System.Collections.Generic;
using UnityEngine;

public class bullet03 : MonoBehaviour {
	float bulletSpeed = 15.0f;
	Rigidbody2D rbd;
	// Use this for initialization
	void Start () {
		rbd = gameObject.GetComponent<Rigidbody2D>();
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Crossbow_Sprite").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Crossbow_Sprite (1)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Crossbow_Sprite (2)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Crossbow_Sprite (3)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Crossbow_Sprite (4)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Crossbow_Sprite (5)").GetComponent<Collider2D>(), true);

		/*Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Gravestone_01_Sprite").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Gravestone_01_Sprite (1)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Gravestone_01_Sprite (2)").GetComponent<Collider2D>(), true);

		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Gravestone_02_Sprite").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Gravestone_02_Sprite (1)").GetComponent<Collider2D>(), true);*/

		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Shrub_Sprite").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Shrub_Sprite (1)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Shrub_Sprite (2)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Shrub_Sprite (3)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Shrub_Sprite (4)").GetComponent<Collider2D>(), true);

		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Log_Sprite").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Log_Sprite (1)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Log_Sprite (2)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Log_Sprite (3)").GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Log_Sprite (4)").GetComponent<Collider2D>(), true);


		Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.Find("Player").GetComponent<Collider2D>(), true);
	}

	// Update is called once per frame
	void Update () {
		Vector2 forwards = gameObject.transform.up;
		gameObject.transform.Translate(forwards * Time.deltaTime * bulletSpeed, Space.World);
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") {
			GameObject.Destroy (gameObject);
		} else if (col.gameObject.tag == "LevelBounds") {
			GameObject.Destroy (gameObject);
		}
	}
}
