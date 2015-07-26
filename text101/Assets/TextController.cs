using UnityEngine;
// Must be added whenever anything with UI is done
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	// Makes a Text variable called text available to all of the methods
	// inside the TextController
	public Text text;

	// Use this for initialization
	void Start () {
		// Sets text to Hello World. Text in canvas (left menu) must be dragged
		// into Text in the Text Inspector (right menu)
		text.text = "Hello World";
	
	}
	
	// Update is called once per frame
	void Update () {
	// If the space key is down then print the text
		if (Input.GetKeyDown(KeyCode.Space)) {
			// Wrapped text using + to concatenate and \n to add a space for new line. 
			// \n\n adds a double space
			text.text = "You are in a prison cell and you want to escape. There are some dirty sheets " +
						"on the bed, a mirror on the wall and a locked door to your cell.\n\n" +
						"Press S to view Sheets, M to view Mirror, L to view Lock";
		}
	
	}
}
