using UnityEngine;
using System.Collections;

public class RaycastDraw : MonoBehaviour {
	private LineRenderer lineRenderer;
	private Transform target;
	void Start(){
		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.useWorldSpace = true;
		lineRenderer.enabled = false;
		lineRenderer.sortingLayerName = "Enemy";
		target = GameObject.Find ("enemyFinder").transform;
	}
	void Update () {
		//RaycastHit2D hit = Physics2D.Raycast(transform.position, target.transform.position);
		//Debug.DrawLine (transform.position, target.transform.position);
		//laserHit.position = hit.point;

		lineRenderer.SetPosition(0,transform.position);
		lineRenderer.SetPosition(1,target.transform.position);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "enemyFinder") {
			lineRenderer.enabled = true;
		}
	}
	void OnTriggerExit2D(Collider2D col){
			if (col.tag == "enemyFinder") {
				lineRenderer.enabled = false;
			}
	}
}
