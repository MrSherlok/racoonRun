using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragMap : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    [SerializeField]
    Transform map;
    int minX = 0;
    int maxX = Screen.width;
    int minY = -20;
    int maxY = Screen.height/2-5;


    public void OnBeginDrag(PointerEventData eventData)
    {

    }
    public void OnDrag(PointerEventData eventData)
    {
        if ((map.gameObject.GetComponent<Transform>().position.x + eventData.delta.x) < maxX &&
            (map.gameObject.GetComponent<Transform>().position.x + eventData.delta.x) > minX)
        {
            map.position += new Vector3(eventData.delta.x * 1.5f, 0f, 0f);
        }

        if ((map.gameObject.GetComponent<Transform>().position.y + eventData.delta.y) < maxY &&
            (map.gameObject.GetComponent<Transform>().position.y + eventData.delta.y) > minY)
        {
            map.position += new Vector3(0f, eventData.delta.y * 1.5f, 0f);
        }
    }
}

