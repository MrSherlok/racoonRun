using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TakeTapScript : MonoBehaviour, IDragHandler, IBeginDragHandler
{
	[SerializeField]
	Transform map;
	int minX = 50;
	int maxX = Screen.width - 50;
	int minY = 20;
	int maxY = Screen.height - 50;


    public void OnBeginDrag(PointerEventData eventData)
    {
		
    }
        public void OnDrag(PointerEventData eventData)
        {
		if ((map.gameObject.GetComponent<RectTransform> ().position.x + eventData.delta.x) < maxX && 
			(map.gameObject.GetComponent<RectTransform> ().position.x + eventData.delta.x) > minX) {	
			map.position += new Vector3 (eventData.delta.x*1.5f, 0f, 0f);
		}

		if ((map.gameObject.GetComponent<RectTransform> ().position.y + eventData.delta.y) < maxY && 
			(map.gameObject.GetComponent<RectTransform> ().position.y + eventData.delta.y) > minY) {	
			map.position += new Vector3 (0f, eventData.delta.y*1.5f, 0f);
		}
    }
}