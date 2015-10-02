using UnityEngine;
using System.Collections;


public class LanternControl : MonoBehaviour
{
	public float lightDuration;
    private Light myLight;
	private float startTime;
	private bool lightOn;


    void Start()
    {
        myLight = GetComponent<Light>();
    }


    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space) && !lightOn)
        {
            myLight.enabled = !myLight.enabled;
			startTime = Time.time;
			lightOn = true;
        }
		if(lightOn && TimeElapsed()>lightDuration){
			myLight.enabled = !myLight.enabled;
			lightOn = false;
		}
    }

	float TimeElapsed(){

		return ((Time.time - startTime)%60);

	}
}