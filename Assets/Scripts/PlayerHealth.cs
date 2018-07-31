using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public UnityEngine.UI.Image Heart1;
    public UnityEngine.UI.Image Heart2;
    public UnityEngine.UI.Image Heart3;
    public int healthPoints = 3;
    [SerializeField] private GameObject losePopUp;

	// Use this for initialization
	void Start () {
        Heart1 = GameObject.Find("Heart1").GetComponent<UnityEngine.UI.Image>();
        Heart2 = GameObject.Find("Heart2").GetComponent<UnityEngine.UI.Image>();
        Heart3 = GameObject.Find("Heart3").GetComponent<UnityEngine.UI.Image>();
		losePopUp.SetActive (false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            if (healthPoints == 3)
            {
                GameObject.Destroy(Heart3);
                --healthPoints;
            }
            else if (healthPoints == 2)
            {
                GameObject.Destroy(Heart2);
                --healthPoints;
            }
            else if (healthPoints == 1)
            {
                GameObject.Destroy(Heart1);
                --healthPoints;
                if(healthPoints <= 0)
                {
                    Time.timeScale = 0;
                    Debug.Log("You lose!");
                    losePopUp.SetActive(true);
                }
            }

        }

        if (col.gameObject.tag == "LevelObstacles")
        {
            GameObject.Destroy(Heart1);
            GameObject.Destroy(Heart2);
            GameObject.Destroy(Heart3);
            healthPoints = 0;
            if (healthPoints <= 0)
            {
                Time.timeScale = 0;
                Debug.Log("You lose!");
                losePopUp.SetActive(true);
            }
        }
    }

    /*void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            --healthPoints;
        }
    }*/
}
