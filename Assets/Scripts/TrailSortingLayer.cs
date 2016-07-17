using UnityEngine;
using System.Collections;

public class TrailSortingLayer : MonoBehaviour {

	LineRenderer trail;
	// Use this for initialization
	void Start ()
	{	
		trail = this.GetComponent<LineRenderer> ();
		trail.sortingLayerName = "Player";
		trail.sortingOrder = 0;
	}
}
