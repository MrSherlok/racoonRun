using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class DragCollection : MonoBehaviour, IDragHandler, IBeginDragHandler
{
	Transform map;
	int minX = -2200;
	int maxX = Screen.width - 10;

	void Start()
	{
		map = transform.GetChild(0);    // получаем ссылку на Transform зеленой панели.
	}

	public void OnBeginDrag(PointerEventData eventData)
	{

	}
	public void OnDrag(PointerEventData eventData)
	{
		if ((map.gameObject.GetComponent<RectTransform> ().position.x + eventData.delta.x) < maxX && 
			(map.gameObject.GetComponent<RectTransform> ().position.x + eventData.delta.x) > minX) {	
			map.position += new Vector3 (eventData.delta.x*3f, 0f, 0f);
		}
	}
}