using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    //BlockForNew

    private Rigidbody2D myRigitbody;
    public float movementSpeed;
    [SerializeField]
    private Transform[] groundPoints;
    [SerializeField]
    private float groundRadius;
    [SerializeField]
    private LayerMask whatIsGround;
    public bool isGrounded = true;
    [SerializeField]
    private bool airControl;
    public float jumpForce;
    public Animator animator;
    private float isgroundtimer;


    void Start()
    {
        myRigitbody = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }

    void FixedUpdate()
    {
        isGrounded = IsGrounded();
		animator.SetBool("IsGrounded", true);
        HendleMovement();

        //	ResetValues ();  //  обнулять переменные

    }

    private void HendleMovement()
    {
        //		Движение через адфорс
        myRigitbody.AddForce(new Vector2(movementSpeed,0));

        //		движение через велосити
       // myRigitbody.velocity = new Vector2(movementSpeed, myRigitbody.velocity.y);

        //		не помню
        /*		if (isGrounded || airControl) {
                    myRigitbody.velocity = new Vector2(movementSpeed, myRigitbody.velocity.y); 
                    }
        */
    }



    public void JumpInput()
    {
        if (isGrounded)
        {
            //		прыжок велосити
            myRigitbody.velocity += jumpForce * Vector2.up;
            //		прыжок адфорс
            //		myRigitbody.AddForce(new Vector2(movementSpeed,jumpForce));
        }
    }

    /*	private void ResetValues()    // обнуление переменных
        {

        }  */

    public bool IsGrounded()
    {
        if (myRigitbody.velocity.y <= 0)
        {
            foreach (Transform point in groundPoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject != gameObject)
                    {
                        return true;


                    }
                }
            }
        }

        return false;

    }

}
