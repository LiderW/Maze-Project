using UnityEngine;
using System.Collections;

public class TrapHole : MonoBehaviour {

	/*void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Object Entered");
	}*/

	void OnTriggerStay(Collider other) {
		other.GetComponent<Collider>().enabled = false;
	}

	/*void OnTriggerExit(Collider other)
	{
		Debug.Log ("Object Exited");
	}*/

}
