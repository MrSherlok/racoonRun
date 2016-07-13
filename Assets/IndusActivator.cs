using UnityEngine;
using System.Collections;

public class IndusActivator : MonoBehaviour {
	public GameObject indusUi;

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.tag == "Player") {
			indusUi.SetActive(true);
		}
	}
}
