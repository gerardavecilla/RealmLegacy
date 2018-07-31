using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerFollow : MonoBehaviour
{
    public Transform target;

    

    private void Start()
    {
        target = GameObject.Find("Player").transform;
	}

	void Update()
	{
        if (Vector3.Distance(transform.position, target.transform.position) < 5.0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.2f * Time.deltaTime);
        }
	}
}