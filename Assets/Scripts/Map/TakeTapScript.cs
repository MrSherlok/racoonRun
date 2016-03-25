using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TakeTapScript : MonoBehaviour, IDragHandler, IBeginDragHandler
{
     Transform map;

    void Start()
    {
        map = transform.GetChild(0);    // получаем ссылку на Transform зеленой панели.
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }
        public void OnDrag(PointerEventData eventData)
        {
        //if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        //{
        //    if (eventData.delta.x > 0) GameObject.Find("Text").GetComponent<Text>().text = "Right";
        //    else GameObject.Find("Text").GetComponent<Text>().text = "Left";

        //    map.position += new Vector3(eventData.delta.x, 0, 0);
        //}
        //else
        //{
        //    if (eventData.delta.y > 0) GameObject.Find("Text").GetComponent<Text>().text = "Up";
        //    else GameObject.Find("Text").GetComponent<Text>().text = "Down";

        //    map.position += new Vector3(0, eventData.delta.y, 0);
        //}
        
        map.position += new Vector3(eventData.delta.x, eventData.delta.y, 0);

    }
}

/*	public bool isCentury19Active = false;

	public void Century19Active () {
		isCentury19Active = true;
	}
*/

