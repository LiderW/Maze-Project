using UnityEngine;
using System.Collections;

public class SuperHearingControl : MonoBehaviour {

	public float lightDuration;
	private Light myLight;
	private float startTime;
	private bool lightOn;
	private float movingTime;
	private int count;
	private bool lightGoDown;
	
	void Start()
	{
		myLight = GetComponent<Light>();
		lightOn = false;
		lightGoDown = false;
		count = 0;
	}
	
	
	void Update()
	{
		
		if (Input.GetKeyUp(KeyCode.Space) && !lightOn)
		{
			myLight.enabled = !myLight.enabled;
			startTime = Time.time;
			lightOn = true;
			movingTime = Time.time;
		}

		if(lightOn && TimeElapsed()>lightDuration){
			myLight.enabled = !myLight.enabled;
			lightOn = false;
		}

		if(lightOn && !lightGoDown){
			if(((Time.time - movingTime) * 100)%100 > 5 && count < 15){
				myLight.transform.localPosition += new Vector3(0, 1, 0);
				movingTime = Time.time;
				count++;
				if(count == 15){ 
					lightGoDown = true;
				}
			}
		}
		if(lightGoDown){
			if(((Time.time - movingTime) * 100)%100 > 5 && count > 0){
				myLight.transform.localPosition += new Vector3(0, -1, 0);
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
