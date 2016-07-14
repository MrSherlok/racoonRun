using UnityEngine;
using System.Collections;

public class OffsetScript : MonoBehaviour {

	public bool x = true;
	public bool y = false;

	void Update () {
		gameObject.GetComponent<Renderer> ().material.mainTextureOffset = new Vector2(Time.frameCount,0);
	}
}
