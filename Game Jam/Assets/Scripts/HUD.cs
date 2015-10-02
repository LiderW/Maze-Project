using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	public TextMesh texto;
	public static int prisioneiros = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		texto.text = "Prisioners: " + prisioneiros;
	}
}
