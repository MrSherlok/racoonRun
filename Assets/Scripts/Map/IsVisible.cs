using UnityEngine;

public class IsVisible : MonoBehaviour
{
    [SerializeField]
    int side = -1;

    BoxCollider2D sideCol;
    [SerializeField]
    Camera cam;

    //-1 - no one
    // 0 - left
    // 1 - right
    // 2 - up
    // 3 - down



    void Start()
    {
        sideCol = this.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (IsVisibleFrom(cam))
        {
            if (side == 0)
            {
                DragMap.IsVisibleXLSide = true;
            }
            else
            {
                if (side == 1)
                {
                    DragMap.IsVisibleXRSide = true;
                }
                else
                {
                    if (side == 2)
                    {
                        DragMap.IsVisibleYUSide = true;
                    }
                    else
                    {
                        if (side == 3)
                        {
                            DragMap.IsVisibleYDSide = true;
                        }
                    }
                }
            }
        }
        else
        {
            if (side == 0)
            {
                DragMap.IsVisibleXLSide = false;
            }
            else
            {
                if (side == 1)
                {
                    DragMap.IsVisibleXRSide = false;
                }
                else
                {
                    if (side == 2)
                    {
                        DragMap.IsVisibleYUSide = false;
                    }
                    else
                    {
                        if (side == 3)
                        {
                            DragMap.IsVisibleYDSide = false;
                        }
                    }
                }
            }
        }
    }

    bool IsVisibleFrom(Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, sideCol.bounds);
    }
}
