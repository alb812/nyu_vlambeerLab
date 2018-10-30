using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	//Intent: Restart scene after pressing [R]
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	    if(Input.GetKeyDown(KeyCode.R))
	    {
			Debug.Log("Press [R] to restart!");
			SceneManager.LoadScene("mainLabScene");
			
			Pathmaker.GlobalTileCount = 0;
	    }
	}
}
