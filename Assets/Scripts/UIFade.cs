using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFade : MonoBehaviour {
	public static UIFade instance;
	public Image fadeScreen;
	public float fadeSpeed;
	public bool shouldFadeToBlack;
	public bool shouldFadeFromBlack;

	// Use this for initialization
	void Start () {
		instance = this;

		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (shouldFadeToBlack) {
			FadeToAlpha(1f);
			
			if (fadeScreen.color.a == 1f) {
				shouldFadeToBlack = false;
			}
		} 
		
		if (shouldFadeFromBlack) {
			FadeToAlpha(0f);

			if (fadeScreen.color.a == 0f) {
				shouldFadeFromBlack = false;
			}
		}
	}

	public void FadeToblack() {
		shouldFadeToBlack = true;
		shouldFadeFromBlack = false;
	}

	public void FadeFromBlack() {
		shouldFadeToBlack = false;
		shouldFadeFromBlack = true;
	}

	private void FadeToAlpha(float alpha) {
		// so we can adapt the speed depending on the power of the computer we use Time.deltatime
		fadeScreen.color = new Color(fadeScreen.color.r, 
			fadeScreen.color.g, 
			fadeScreen.color.b, 
			Mathf.MoveTowards(fadeScreen.color.a, alpha, fadeSpeed * Time.deltaTime));
	}
}
