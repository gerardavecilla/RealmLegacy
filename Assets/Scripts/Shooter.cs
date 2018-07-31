using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile;
    public float speedFactor;
    public float delay;

	// Use this for initialization
	void Start () {
        StartCoroutine(Shoots());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Shoots()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);

            GameObject clone = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);

            clone.GetComponent<Rigidbody2D>().velocity = -transform.right * speedFactor;
        }
    }

   /* void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "LevelBounds")
        {
            GameObject.Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Player")
        {
            --healthPoints;
        }
    }*/
}
