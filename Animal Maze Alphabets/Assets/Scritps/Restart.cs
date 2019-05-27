using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ResetScene(string SceneName)
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void QuitApplicatio()
	{
		Application.Quit ();
	}


}
