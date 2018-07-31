﻿using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update() {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}

}