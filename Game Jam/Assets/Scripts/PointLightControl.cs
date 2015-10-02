using UnityEngine;
using System.Collections;

public class PointLightControl : MonoBehaviour
{
    public float intensityModifier;
    private Light myPointLight;
    private float multiplier = -1;
	public float lightDuration;
	private float startTime;
	private bool lightOn;
	
	void Start()
    {
        myPointLight = GetComponent<Light>();
		lightOn = false;
		myPointLight.intensity = intensityModifier * multiplier;
		multiplier = multiplier * -1;
		
		
	}
	
	
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !lightOn)
        {
            myPointLight.intensity = intensityModifier * multiplier;
            multiplier = multiplier * -1;
			startTime = Time.time;
			lightOn = true;
        }
		if(lightOn && TimeElapsed()>lightDuration){
			myPointLight.intensity = intensityModifier * multiplier;
			multiplier = multiplier * -1;
			lightOn = false;
		}

    }

	float TimeElapsed(){
		
		return ((Time.time - startTime)%60);
		
	}
}