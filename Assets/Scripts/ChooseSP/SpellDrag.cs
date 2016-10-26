using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class SpellDrag : MonoBehaviour {
	bool isDragging;
	bool isMouseDown;

	public string animationName;
	Animator playerAnimator;
	int i = 0;

	float timeout = 0.15f;
	float startTime;
	Vector3 previousMousePos = Vector3.zero;
	public Transform map;
	int minY = -100;
	int maxY = Screen.height + 100;
	int averY = 0;


	public UnityEvent OnClickEvent;

	void Start() {
		averY = maxY / 2;
		playerAnimator = GameObject.Find ("Player1").GetComponent<Animator> ();
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
		if (isDragging) {
			Vector3 delta = Input.mousePosition - previousMousePos;

			if ((map.gameObject.GetComponent<RectTransform> ().position.y + delta.y) < maxY &&
				(map.gameObject.GetComponent<RectTransform> ().position.y + delta.y) > minY) {
				map.position += new Vector3 (0f, delta.y*2f, 0f);
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
	public void PlaySPAnim(){
		Debug.Log (i);
		if (i == 2) {
			i = 0;
		}
		if (animationName != null && i == 0) {
			playerAnimator.SetTrigger (animationName);
		}
		i++;
	}
}