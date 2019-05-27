using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {
	
	public GameObject AlphabetPoof;
	public static int CollectedStars = 0;

	public float verticalSpeed = 0.7f;
	public float rotationalSpeed = 3f;
	private Vector3 startingPosition;
	public GUIText StarCount;

		void Start()
	{
		startingPosition = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = startingPosition + new Vector3(0f, Mathf.Sin(Time.time) * verticalSpeed, 0f);
		transform.Rotate(0f, Mathf.Sin(Time.time) * rotationalSpeed, 0f);

	}

	public void OnStarClicked()
	{
		Instantiate(AlphabetPoof, transform.position, Quaternion.Euler(-90, 0, 0));

		// Destroying the coin gameobject
		Destroy(gameObject);

		//Adding one more coin to the total number collected so far
		CollectedStars= CollectedStars + 1;

		ScoreScript.ScoreValue = CollectedStars;

		//Debug.Log("Number of collected stars : " + CollectedStars);
	}




}
