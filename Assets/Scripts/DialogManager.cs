using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {
	public Text dialogText;
	public Text nameText;
	public GameObject dialogBox;
	public GameObject nameBox;
	public string[] dialogLines;
	public int currentLine;
	public static DialogManager instance;
	private bool justStarted;

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (dialogBox.activeInHierarchy) {
			if (Input.GetButtonUp("Fire1") && !justStarted) {
				currentLine++;

				if (currentLine >= dialogLines.Length) {
					dialogBox.SetActive(false);
				} else {
					dialogText.text = dialogLines[currentLine];
				}
			} else if (Input.GetButtonUp("Fire1")) {
				justStarted = false;
			}
		}
	}

	public void ShowDialog(string[] newLines) {
		dialogLines = newLines;
		currentLine = 0;
		dialogText.text = dialogLines[currentLine];
		dialogBox.SetActive(true);
		justStarted = true;
	}
}
