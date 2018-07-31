using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject laserPrefab;
    public static int enemiesKilled = 0;
    float timer = 0.9f;
    float XPtimermultiplier = 1.0f; //reduce to increase fire rate

	// Use this for initialization
	void Start () {
        laserPrefab = GameObject.Find("LaserPrefab");
	}
	

	void Update () {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (timer > 0.4 * XPtimermultiplier)
            {
                Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                Instantiate(laserPrefab, transform.position, Quaternion.AngleAxis(angle + 266, Vector3.forward));
                timer = 0.0f;
            }
        }
        timer += Time.deltaTime;
        if (enemiesKilled >= 10)
        {
            XPtimermultiplier = 0.5f;
        }
        if(timer > 100000f)
        {
            timer = 0.9f;
        }
    }
}
