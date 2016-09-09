using UnityEngine;
using System.Collections;

public class FX_OrderLayer : MonoBehaviour {

	void Start () {
		GetComponent<TrailRenderer> ().sortingLayerName = "Effects";	
}
}