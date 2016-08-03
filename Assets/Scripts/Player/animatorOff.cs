using UnityEngine;
using System.Collections;

public class animatorOff : MonoBehaviour {

	void OnAnimationEnd() {
		gameObject.SetActive(false);
	}
}
