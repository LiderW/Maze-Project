using UnityEngine;
using System.Collections;

public class SuperHearingCamera : MonoBehaviour {
		
	public float lightDuration;
	private Camera myCamera;
	private float startTime;
	private bool lightOn;
	private float movingTime;
	private int count;
	private bool lightGoDown;
	public GameObject player;
		
	void Start()
	{
		myCamera = GetComponent<Camera>();
		lightOn = false;
		lightGoDown = false;
		count = 0;

	}
		
		
	void Update()
	{
			
		if (Input.GetKeyUp(KeyCode.Space) && !lightOn)
		{
			startTime = Time.time;
			lightOn = true;
			movingTime = Time.time;
	
		}
			
		if(lightOn && TimeElapsed()>lightDuration){
			lightOn = false;
		}
			
		if(lightOn && !lightGoDown){
			if(((Time.time - movingTime) * 100)%100 > 5 && count < 15){
				myCamera.transform.localPosition += new Vector3(0, 1, 0);
				movingTime = Time.time;
				count++;
				if(count == 15){ 
					lightGoDown = true;
				}
			}
		}
		/*if(!lightOn){

			myCamera.transform.localPosition = new Vector3(0, 15, -5);

		}*/
		if(lightGoDown){
			if(((Time.time - movingTime) * 100)%100 > 5 && count > 0){
				myCamera.transform.localPosition += new Vector3(0, -1, 0);
				movingTime = Time.time;
				count--;
				if(count == 0){
					lightGoDown = false;
				}
			}
		}
	}
		
	float TimeElapsed(){
			
		return ((Time.time - startTime)%60);
			
	}
}
