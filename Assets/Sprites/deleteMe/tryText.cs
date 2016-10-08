using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tryText : MonoBehaviour
{

    [SerializeField]
    Text txt;
    bool one = false;

    void OnMouseDown()
    {
        one = !one;
        if(one)
        {
            txt.text = this.name;
        } else
        {
            txt.text = "";
        }

    }
}
