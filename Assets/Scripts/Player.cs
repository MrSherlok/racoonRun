using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigitbody;
    public float movementSpeed;
  //  [SerializeField]
 //   private Transform[] groundPoints;
//    [SerializeField]
   // private float groundRadius;
  //  public LayerMask whatIsGround;
  //  public bool isGrounded = true;
//    [SerializeField]
//    private bool airControl;
    public float jumpForce;

	public static Animator playerAnimator;
    private float isgroundtimer;

	//IsGrounded start
	public float groundCheckRadius;
	public Transform groundCheck;
	public LayerMask whatIsGrounded;
	public static bool IsGrounded;

	//IsGrounded  end
	//IsClouded start
	public float isCloudCheckRadius;//адиус соприкосновения глова-хмара
	public Transform isCloudCheck; // сама точка на голове (headpoint)
	public LayerMask whatIsCloud; // леер для определения соприкосновений с тучками
	public static bool isCloudHeadTouch; // возвращает true когда голова в контакте с тучей
	public static bool isCloudfootTouch;// возвращает true когда персонаж стоит на туче

    //IsClouded end

    bool isSuperJumpActive;       //переменная на проверку активен ли супер прыжок



    void Start()
    {
		playerAnimator = GameObject.Find("Player1").GetComponent<Animator>();
        myRigitbody = GetComponent<Rigidbody2D>();
//        Time.timeScale = 1f;

    }

    void FixedUpdate()
    {
//		isSuperJumpActive = SuperPower.superJumpEnabled;
        IsGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGrounded);
		isCloudHeadTouch = Physics2D.OverlapCircle(isCloudCheck.position, isCloudCheckRadius, whatIsCloud);
		isCloudfootTouch = Physics2D.OverlapCircle(groundCheck.position, isCloudCheckRadius, whatIsCloud);
		playerAnimator.SetBool("IsGrounded", IsGrounded);
		//animator.CrossFade ("Run",2);
//        HendleMovement();
        
        //	ResetValues ();  //  обнулять переменные

    }

/*	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "BlackCloud") {
			if (isCloudHeadTouch && isSuperJumpActive) { //Если голова касается тучки
				playerAnimator.SetTrigger ("Cloudjump");
			}

			if (isCloudfootTouch && isSuperJumpActive) //Если голова касается тучки
			{
				playerAnimator.SetTrigger ("Cloudjump2");
			}
		}
	}
*/
/*    private void HendleMovement()
    {
        //		Движение через адфорс
        myRigitbody.AddForce(new Vector2(movementSpeed,0));

        //		движение через велосити
       // myRigitbody.velocity = new Vector2(movementSpeed, myRigitbody.velocity.y);

        //		не помню
        /*		if (isGrounded || airControl) {
                    myRigitbody.velocity = new Vector2(movementSpeed, myRigitbody.velocity.y); 
                    }
        
    }
*/


    public void JumpInput()
		{
			if (PauseScript.isPause) {
			if (IsGrounded == true) {
            
				//		прыжок велосити
				myRigitbody.velocity += jumpForce * Vector2.up;
				//		прыжок адфорс
				//		myRigitbody.AddForce(Vector2.up * jumpForce);
			}
		}
	}

    /*	private void ResetValues()    // обнуление переменных
        {

        }  */

/*    public bool IsGrounded()
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

    }*/

}
