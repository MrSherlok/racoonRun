﻿using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	
public TrailRenderer trail;
//public ParticleSystem particleSystem;
// Use this for initialization
void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        trail.sortingLayerName = "Effects";
	trail.sortingOrder = 0;
	//particleSystem.sortingLayerName = "Effects";
	//particleSystem.renderer.sortingLayerName = "Effects";
	}
}