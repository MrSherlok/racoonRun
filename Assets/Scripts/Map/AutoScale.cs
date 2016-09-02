using UnityEngine;
using System.Collections;

public class AutoScale : MonoBehaviour {

	float koefX;
	float koefY;

	void Start() {
		koefX = Screen.width / 1600f;
		koefY = Screen.height / 900f;

		gameObject.transform.localScale = new Vector3 (koefX, koefY, 1f);
	}
}
