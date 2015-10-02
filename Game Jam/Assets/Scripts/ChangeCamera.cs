using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

	public Camera blindCamera;
	public Camera deafCamera;
	public GameObject player;

	// Use this for initialization
	void Start () {
		blindCamera.enabled = true;
		deafCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.C)){
			deafCamera.enabled = !deafCamera.enabled;
			blindCamera.enabled = !blindCamera.enabled;

		}
	}
}

