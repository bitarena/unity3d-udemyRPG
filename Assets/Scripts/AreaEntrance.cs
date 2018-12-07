using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour {
	public string transitionName;

	// Use this for initialization
	void Start () {
		if (!string.IsNullOrEmpty(transitionName) && 
			transitionName == PlayerController.instance.areaTransitionName) {
			PlayerController.instance.transform.position = transform.position;
		}

		UIFade.instance.FadeFromBlack();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
