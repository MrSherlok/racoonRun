using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class DraggingScript : MonoBehaviour {

	bool isDragging;
	bool isMouseDown;
	float timeout = 0.15f;
	float startTime;
	Vector3 previousMousePos = Vector3.zero;
	public Transform map;
	int minX = 50;
	int maxX = Screen.width - 50;
	int minY = 20;
	int maxY = Screen.height - 50;


	public UnityEvent OnClickEvent;


	public void OnMouseDown ()
	{
		startTime = Time.time;
		isMouseDown = true;
	}

	public void OnMouseUp ()
	{
		isMouseDown = isDragging = false;
		if (Time.time < (startTime + timeout)) {
			OnClickEvent.Invoke ();
		}
	}

	void Update ()
	{
		if (isDragging) {
			Vector3 delta = Input.mousePosition - previousMousePos;

			if ((map.gameObject.GetComponent<RectTransform> ().position.y + delta.y) < maxY && 
				(map.gameObject.GetComponent<RectTransform> ().position.y + delta.y) > minY && 
				(map.gameObject.GetComponent<RectTransform> ().position.x + delta.x) < maxX && 
				(map.gameObject.GetComponent<RectTransform> ().position.x + delta.x) > minX) {	
				map.position += delta*1.5f;

				if ((map.gameObject.GetComponent<RectTransform> ().position.x + delta.x) < maxX && 
					(map.gameObject.GetComponent<RectTransform> ().position.x + delta.x) > minX) {	
					map.position += new Vector3 (delta.x*1.5f, 0f, 0f);
				}

				if ((map.gameObject.GetComponent<RectTransform> ().position.y + delta.y) < maxY && 
					(map.gameObject.GetComponent<RectTransform> ().position.y + delta.y) > minY) {	
					map.position += new Vector3 (0f,delta.y*1.5f, 0f);
				}
			}

			previousMousePos = Input.mousePosition;
			return;
		}

		if (isMouseDown) {
			if (Time.time > (startTime + timeout)) {
				previousMousePos = Input.mousePosition;
				isDragging = true;
			}
		}
	}
}
