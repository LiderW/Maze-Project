using UnityEngine;
using System.Collections;

public class ParticleActivator : MonoBehaviour {

	private ParticleSystem particleSonar;
	private bool particleOn;
	private float startTime;


	// Use this for initialization
	void Start () {
		particleOn = false;
		particleSonar = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space) && !particleOn)
		{
			transform.position = PlayerController1.posicao;
			startTime = Time.time;
			particleSonar.Emit(1000);
			startTime = Time.time;
			particleOn = true;
		}
		if(TimeElapsed() > 5 && particleOn){
			particleOn = false;
		}
	}

	float TimeElapsed(){
		
		return ((Time.time - startTime)%60);
		
	}

}
