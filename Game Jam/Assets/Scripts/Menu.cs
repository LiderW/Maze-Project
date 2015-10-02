using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

	public Canvas quitMenu;
	public Button startMessage;
	public Button exitText;

	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas>();
		startMessage = startMessage.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();
		quitMenu.enabled = false;

	}
	
	// Update is called once per frame
	public void ExitPress () {
		quitMenu.enabled = true;
		startMessage.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress(){
		quitMenu.enabled = false;
		startMessage.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel(){
		Application.LoadLevel(1);
	}

	public void ExitGame(){
		Application.Quit ();
	}

	public void Credits(){
		Application.LoadLevel(2);
	}
}
