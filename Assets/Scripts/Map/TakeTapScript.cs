using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TakeTapScript : MonoBehaviour, IDragHandler, IBeginDragHandler
{
	Transform map;
	int minX = 50;
	int maxX = 900;
	int minY = 20;
	int maxY = 500;

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
			(map.gameObject.GetComponent<RectTransform> ().position.y + eventData.delta.y) > minY && 
			(map.gameObject.GetComponent<RectTransform> ().position.x + eventData.delta.x) < maxX && 
			(map.gameObject.GetComponent<RectTransform> ().position.x + eventData.delta.x) > minX) {	
			map.position += new Vector3 (eventData.delta.x, eventData.delta.y, 0f);
		}
    }
}