using UnityEngine;
using UnityEngine.SceneManagement;

public class MapDragging : MonoBehaviour {
	private Animator cameraAnimator;
    //for dragging point
    bool isDragging;
    bool isMouseDown;
    float timeout = 0.15f;
    float startTime;
    Vector3 previousMousePos = Vector3.zero;

    // map limit to drag
    [SerializeField]
    Transform map;
    //int minX = 50;
    //int maxX = Screen.width;
    //int minY = -20;
    //int maxY = Screen.height - 20;
    

    //for scene load
    AudioSource clickSound;
    [SerializeField]
    bool itsTutorialLevel = false;
    //Если истина - включаем сценку с комиксом
    [SerializeField]
    bool isComixScene = false;
    void Start()
    {	
		cameraAnimator = GameObject.Find ("Main Camera").GetComponent<Animator>();
        clickSound = GameObject.Find("SoundBox").GetComponent<AudioSource>();
    }


    void OnMouseDown()
    {
        startTime = Time.time;
        isMouseDown = true;
    }

    void OnMouseUp()
    {
        isMouseDown = isDragging = false;
        if (Time.time < (startTime + timeout))
        {
            GoToChoseSP();
        }
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 delta = Input.mousePosition - previousMousePos;


            if (DragMap.IsVisibleXLSide && delta.x < 0)
            {
                map.position += new Vector3(delta.x, 0f, 0f);
            }
            else
            {
                if (DragMap.IsVisibleXRSide && delta.x > 0)
                {
                    map.position += new Vector3(delta.x, 0f, 0f);
                }
                else
                {
                    if (!DragMap.IsVisibleXLSide && !DragMap.IsVisibleXRSide)
                    {
                        map.position += new Vector3(delta.x, 0f, 0f);
                    }
                }
            }

            if (DragMap.IsVisibleYUSide && delta.y > 0)
            {
                map.position += new Vector3(0f, delta.y, 0f);
            }
            else
            {
                if (DragMap.IsVisibleYDSide && delta.y < 0)
                {
                    map.position += new Vector3(0f, delta.y, 0f);
                }
                else
                {
                    if (!DragMap.IsVisibleYUSide && !DragMap.IsVisibleYDSide)
                    {
                        map.position += new Vector3(0f, delta.y, 0f);
                    }
                }




                //if ((map.gameObject.GetComponent<Transform>().position.y + delta.y) < maxY &&
                //    (map.gameObject.GetComponent<Transform>().position.y + delta.y) > minY &&
                //    (map.gameObject.GetComponent<Transform>().position.x + delta.x) < maxX &&
                //    (map.gameObject.GetComponent<Transform>().position.x + delta.x) > minX)
                //{
                //    map.position += delta * 1.5f;

                //    if ((map.gameObject.GetComponent<Transform>().position.x + delta.x) < maxX &&
                //        (map.gameObject.GetComponent<Transform>().position.x + delta.x) > minX)
                //    {
                //        map.position += new Vector3(delta.x * 1.5f, 0f, 0f);
                //    }

                //    if ((map.gameObject.GetComponent<Transform>().position.y + delta.y) < maxY &&
                //        (map.gameObject.GetComponent<Transform>().position.y + delta.y) > minY)
                //    {
                //        map.position += new Vector3(0f, delta.y * 1.5f, 0f);
                //    }
                //}

                previousMousePos = Input.mousePosition;
                return;
            }

            if (isMouseDown)
            {
                if (Time.time > (startTime + timeout))
                {
                    previousMousePos = Input.mousePosition;
                    isDragging = true;
                }
            }
        }
    }

    void GoToChoseSP()
    {	
		
        PlayerPrefs.SetString("ChosingLevel", gameObject.name);
        if (itsTutorialLevel)
        {	
			cameraAnimator.SetTrigger("NextScene");
           Invoke("GoToLoadScene", 1.2f);
            
        }
        else
        {	
			cameraAnimator.SetTrigger("NextScene");
            Invoke("GoToChoseSpels", 1.2f);
            
        }
        clickSound.Play();
    }
    void GoToChoseSpels()
	{
		SceneManager.LoadScene("chooseSP");
	}
	void GoToLoadScene()
	{
		SceneManager.LoadScene("LoadScene");
	}

}