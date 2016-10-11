using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragMap : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    [SerializeField]
    Transform map;
    //int minX = 0;
    //int maxX = Screen.width;
    //int minY = -20;
    //int maxY = Screen.height / 2 - 5;


    public static bool IsVisibleXLSide = false;
    public static bool IsVisibleXRSide = false;
    public static bool IsVisibleYUSide = false;
    public static bool IsVisibleYDSide = false;


    public void OnBeginDrag(PointerEventData eventData)
    {

    }
    public void OnDrag(PointerEventData eventData)
    {        
        if (IsVisibleXLSide && eventData.delta.x < 0)
            {
                map.position += new Vector3(eventData.delta.x, 0f, 0f);
            }
        else
        {
            if (IsVisibleXRSide && eventData.delta.x > 0)
                {
                    map.position += new Vector3(eventData.delta.x, 0f, 0f);
                }
            else
            {
                if (!IsVisibleXLSide && !IsVisibleXRSide)
                {
                    map.position += new Vector3(eventData.delta.x, 0f, 0f);
                }
            }
        }

        if (IsVisibleYUSide && eventData.delta.y > 0)
            {
                map.position += new Vector3(0f, eventData.delta.y, 0f);
            }
        else
        {
            if (IsVisibleYDSide && eventData.delta.y < 0)
                {
                    map.position += new Vector3(0f, eventData.delta.y, 0f);
                }
            else
            {
                if (!IsVisibleYUSide && !IsVisibleYDSide)
                {
                    map.position += new Vector3(0f, eventData.delta.y, 0f);
                }
            }
        }


        //if ((map.gameObject.GetComponent<Transform>().position.x + eventData.delta.x) < maxX &&
        //    (map.gameObject.GetComponent<Transform>().position.x + eventData.delta.x) > minX)
        //{
        //    map.position += new Vector3(eventData.delta.x * 1.5f, 0f, 0f);
        //}

        //if ((map.gameObject.GetComponent<Transform>().position.y + eventData.delta.y) < maxY &&
        //    (map.gameObject.GetComponent<Transform>().position.y + eventData.delta.y) > minY)
        //{
        //    map.position += new Vector3(0f, eventData.delta.y * 1.5f, 0f);
        //}
    }


}

