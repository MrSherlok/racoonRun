using UnityEngine;
using System.Collections;

public class AutoScale : MonoBehaviour {

	float koefX;
	float koefY;

	void Start() {
		koefX = Screen.width / 1024f;
		koefY = Screen.height / 600f;

		gameObject.transform.localScale = new Vector3 (koefX, koefY, 1f);
	}
}
