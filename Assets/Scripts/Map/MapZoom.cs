﻿using UnityEngine;

public class MapZoom : MonoBehaviour
{
    [SerializeField]
    float orthoZoomSpeed = 1.5f;
    [SerializeField]
    Camera cam;
    [SerializeField]
    GameObject bg;


    void Update()
    {
        // If there are two touches on the device...
        if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // ... change the orthographic size based on the change in distance between the touches.
            if ((!(DragMap.IsVisibleXLSide && DragMap.IsVisibleXRSide) || !(DragMap.IsVisibleYDSide && DragMap.IsVisibleYUSide)))
            {
                if(cam.orthographicSize + deltaMagnitudeDiff > 200)
                {
                    cam.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;

                    //bg size
                    bg.GetComponent<Transform>().localScale = new Vector2(cam.orthographicSize / 200, cam.orthographicSize / 200);

                    // Make sure the orthographic size never drops below zero.
                    cam.orthographicSize = Mathf.Max(cam.orthographicSize, 0.1f);
                }
            }
        }
    }
}

