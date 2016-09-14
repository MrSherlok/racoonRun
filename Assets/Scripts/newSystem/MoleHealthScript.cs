using UnityEngine;
using System.Collections;

public class MoleHealthScript : MonoBehaviour
{
    [SerializeField]
    int hp = 2;


    void OnTriggerEnter2D(Collider2D collider)
    {

        ShotScript shot = collider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {

            if (collider.gameObject.tag == "superPunch")
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                gameObject.GetComponent<ShotScript>().enabled = false;
                //ТИХОН ТУТ АНИМАЦИЯ С УБИЙСТВОМ КРОТА

               // Destroy(gameObject, 3f);
            }
        }
    }
}

