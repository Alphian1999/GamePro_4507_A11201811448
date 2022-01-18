﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penmovement2 : MonoBehaviour
{

	public static float speed = 40f;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.D))
			transform.Translate(speed * Vector3.right * Time.deltaTime);
		if (Input.GetKey(KeyCode.A))
			transform.Translate(speed * Vector3.left * Time.deltaTime);
		if (Input.GetKey(KeyCode.W))
			transform.Translate(speed * Vector3.up * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "jedot")
		{
			Application.LoadLevel("replay");
		}
		if (col.gameObject.tag == "huruf")
		{
			Destroy(col.gameObject);
			ScoreScript.scoreValue += 10;
		}
		if (col.gameObject.tag == "fin")
		{
			Application.LoadLevel("Finish");
		}
	}
}