	using UnityEngine;
	using System.Collections;
	using UnityEngine.Events;

public class ItemDrag : MonoBehaviour {
	bool isDragging;
	bool isMouseDown;
	float timeout = 0.15f;
	float startTime;
	Vector3 previousMousePos = Vector3.zero;
	public Transform map;
	int minX = -2200;
	int maxX = Screen.width - 10;
	int averX;


	public UnityEvent OnClickEvent;

	void Start() {
		averX = maxX / 2;
	}


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

		if (gameObject.GetComponent<RectTransform> ().position.x != averX) {
			if (gameObject.GetComponent<RectTransform> ().position.x > averX) {
				gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (averX/(gameObject.GetComponent<RectTransform> ().position.x - averX+(averX/2)),  averX/(gameObject.GetComponent<RectTransform> ().position.x - averX+(averX/2)) , 0f);
			} else {
				gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (averX/(averX - gameObject.GetComponent<RectTransform> ().position.x+(averX/2)) , averX/(averX - gameObject.GetComponent<RectTransform> ().position.x+(averX/2)) , 0f);
			}
			//gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (gameObject.GetComponent<RectTransform> ().position.x/500f, gameObject.GetComponent<RectTransform> ().position.x/500f, 0f);
		}



	/*	if (gameObject.GetComponent<RectTransform> ().position.x >= averX) {
			gameObject.GetComponent<RectTransform> ().localScale = new Vector3 ((1000f - gameObject.GetComponent<RectTransform> ().position.x)/500f, (1000f - gameObject.GetComponent<RectTransform> ().position.x)/500f, 0f);
		} else {
			if(gameObject.GetComponent<RectTransform> ().position.x<=averX)
			gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (gameObject.GetComponent<RectTransform> ().position.x/500f, gameObject.GetComponent<RectTransform> ().position.x/500f, 0f);
		}
*/		if (isDragging) {
			Vector3 delta = Input.mousePosition - previousMousePos;

			if ((map.gameObject.GetComponent<RectTransform> ().position.x + delta.x) < maxX &&
			    (map.gameObject.GetComponent<RectTransform> ().position.x + delta.x) > minX) {
				map.position += new Vector3 (delta.x, 0f, 0f);
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