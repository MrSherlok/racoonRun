 using UnityEngine;
 using System.Collections;
 public class CookieRangScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;


    void Update()
    {
        
            StartCoroutine(Throw(18.0f, 1.0f, Camera.main.transform.forward, 2.0f));
       
   }
    IEnumerator Throw(float dist, float width, Vector3 direction, float time)
    {
        Vector3 pos = transform.position;
        float height = transform.position.y;
        Quaternion q = Quaternion.FromToRotation(Vector3.forward, direction);
        float timer = 0.0f;
        rigidbody.AddTorque(0.0f, 400.0f, 0.0f);
        while (timer < time)
        {
            float t = Mathf.PI * 2.0f * timer / time - Mathf.PI / 2.0f;
            float x = width * Mathf.Cos(t);
            float z = dist * Mathf.Sin(t);
            Vector3 v = new Vector3(x, height, z + dist);
            rigidbody.MovePosition(pos + (q * v));
            timer += Time.deltaTime;
            yield return null;
        }

        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.velocity = Vector3.zero;
        rigidbody.rotation = Quaternion.identity;
        rigidbody.MovePosition(pos);
    }
}
