using UnityEngine;
using UnityEngine.EventSystems;


public class DragSP : MonoBehaviour, IDragHandler, IBeginDragHandler {
	Transform map;
	int minY = -100;
	int maxY = Screen.height + 100;

	void Start()
	{
		map = transform.GetChild(0);    // получаем ссылку на Transform зеленой панели.
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	
	}

	public void OnDrag(PointerEventData eventData)
	{
		if ((map.gameObject.GetComponent<RectTransform> ().position.y + eventData.delta.y) < maxY && 
			(map.gameObject.GetComponent<RectTransform> ().position.y + eventData.delta.y) > minY) {	
			map.position += new Vector3 (0f, eventData.delta.y*2f, 0f);
		}
	}
}
