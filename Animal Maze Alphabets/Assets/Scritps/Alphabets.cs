using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alphabets : MonoBehaviour {
	
	public GameObject AlphabetPoof;
	public float rotationalSpeed = 3f;

	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(0f, Mathf.Sin(Time.time) * rotationalSpeed, 0f);

	}

	public void OnAlphabetClicked()
	{
		Instantiate(AlphabetPoof, transform.position, Quaternion.Euler(-90, 0, 0));

		// Destroying the coin gameobject
		Destroy(gameObject);

	}


}