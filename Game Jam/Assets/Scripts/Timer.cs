using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float startTime;
	private float timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		timer = (Time.time - startTime)%60;

	}

	public bool TimeElapsed(){
		if(timer > 30){
		
			TimeStart();
			return true;
		
		}else{
			return false;
		}
	}

	public void TimeStart(){

		startTime = Time.time;

	}
}
