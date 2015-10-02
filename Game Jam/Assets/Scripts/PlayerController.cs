//using UnityEngine;
//using System.Collections;

//public class PlayerController : MonoBehaviour
//{

//    public float speed;
//    public float speedChanger;
//    public float sideSpeedChanger;
//    public float sideSpeed;
//    public float maxSpeed;
//    private Rigidbody playerRigidBody;
//    private bool upPressed;
//    private bool downPressed;
//    private bool rightPressed;
//    private bool leftPressed;
//    private Animator animator;

//    // Use this for initialization
//    void Start()
//    {

//        playerRigidBody = GetComponent<Rigidbody>();
//        animator = GetComponent<Animator>();
//        upPressed = false;
//        downPressed = false;
//        rightPressed = false;
//        leftPressed = false;

//    }

//    // Update is called once per frame
//    void Update()
//    {

//        //playerRigidBody.velocity = new Vector3(sideSpeed,
//        //                                        playerRigidBody.velocity.y, 0);

//		Vector3 movementDirection = Vector3.zero;
//        Checker();
//        //adicionadores de velocidade
//        if (upPressed)
//        {
//            //transform.localPosition += transform.forward * speed * Time.deltaTime;
//			movementDirection = transform.forward * speed * 0.05f;
//            animator.SetBool("isWalking", true);
//        }
//        if (downPressed)
//        {
//            //transform.localPosition -= transform.forward * speed * Time.deltaTime;
//			movementDirection = Vector3.zero;
//            animator.SetBool("isWalking", true);
//        }
//        if (rightPressed && sideSpeed < maxSpeed)
//        {
//            transform.Rotate(0.0f, 1.0f, 0.0f);
//            animator.SetBool("isWalking", true);
//        }
//        if (leftPressed && sideSpeed > -maxSpeed)
//        {
//            transform.Rotate(0.0f, -1.0f, 0.0f);
//            animator.SetBool("isWalking", true);
//        }

//		playerRigidBody.AddForce(movementDirection, ForceMode.VelocityChange);

//		/*Vector3 movementDirection;
//		if(upPressed)
//		{
//			movementDirection = transform.forward * speed * 0.05f;
//		}
//		else
//		{
//			movementDirection = Vector3.zero;
//		}

//		playerRigidBody.AddForce(movementDirection, ForceMode.VelocityChange);*/

//        //zeradores de velocidade
//       /* if (!leftPressed && !rightPressed)
//        {
//            if (sideSpeed < 0)
//            {
//                sideSpeed += sideSpeedChanger;
//            }
//            else if (sideSpeed > 0)
//            {
//                sideSpeed -= sideSpeedChanger;
//            }
//        }
//        if (!downPressed && !upPressed)
//        {
//            if (speed < 0)
//            {
//                speed += speedChanger;
//            }
//            else if (speed > 0)
//            {
//                speed -= speedChanger;
//            }
//        }*/

//    }

//    //key pressed?

//    void Checker()
//    {
//		Vector3 movementDirection;



//        if (Input.GetKeyDown(KeyCode.W))
//        {

//            upPressed = true;
//			//movementDirection = transform.forward * speed * 0.05f;

//        }
//        else if (Input.GetKeyUp(KeyCode.W))
//        {
//            upPressed = false;
//			//movementDirection = Vector3.zero;
//            animator.SetBool("isWalking", false);
//        }

//        if (Input.GetKeyDown(KeyCode.S))
//        {

//            downPressed = true;

//        }
//        else if (Input.GetKeyUp(KeyCode.S))
//        {
//            downPressed = false;
//            animator.SetBool("isWalking", false);
//        }

//        if (Input.GetKeyDown(KeyCode.D))
//        {

//            rightPressed = true;
            

//        }
//        else if (Input.GetKeyUp(KeyCode.D))
//        {
//            rightPressed = false;
//            animator.SetBool("isWalking", false);
//        }

//        if (Input.GetKeyDown(KeyCode.A))
//        {

//            leftPressed = true;
            

//        }
//        else if (Input.GetKeyUp(KeyCode.A))
//        {
//            leftPressed = false;
//            animator.SetBool("isWalking", false);
//        }

//		//playerRigidBody.AddForce(movementDirection, ForceMode.VelocityChange);

//    }


//}

//88888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888
/*
private void moveForward(float speed)
{
    transform.localPosition += transform.forward * speed * Time.deltaTime;
}

private void moveBack(float speed)
{
    transform.localPosition -= transform.forward * speed * Time.deltaTime;
}

private void moveRight(float speed)
{
    transform.localPosition += transform.right * speed * Time.deltaTime;
}

private void moveLeft(float speed)
{
    transform.localPosition -= transform.right * speed * Time.deltaTime;
}*/
