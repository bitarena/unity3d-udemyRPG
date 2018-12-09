using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour {
	public GameObject UIScreen;
	public GameObject player;
	public GameObject gameManager;

	// Use this for initialization
	void Start () {
		if (UIFade.instance == null) {
			UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
		}
		if (PlayerController.instance == null) {
			var clone = Instantiate(player).GetComponent<PlayerController>();
			PlayerController.instance = clone;
		}

		if (GameManager.instance == null) {
			Instantiate(gameManager);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
