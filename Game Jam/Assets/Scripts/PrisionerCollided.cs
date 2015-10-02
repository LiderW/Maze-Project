using UnityEngine;
using System.Collections;

public class PrisionerCollided : MonoBehaviour {
		
		void OnTriggerEnter(Collider other)
	{
		HUD.prisioneiros--;
		GetComponent<Collider>().enabled = false;
	}
		
		/*void OnTriggerStay(Collider other) {
			other.GetComponent<Collider>().enabled = false;
		}*/
		
		/*void OnTriggerExit(Collider other)
	{
		Debug.Log ("Object Exited");
	}*/
		
	}
