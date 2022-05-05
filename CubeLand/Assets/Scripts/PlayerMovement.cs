using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    //public Animator animator;
    public float forwardForce = 50f;
    public float sidewaysForce = 500f;
    public Joystick joystick;
    //public float moveSpeed = 6f;
    //float horizontalMove = 0f;


    /*void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }*/
    /*void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        horizontalMove = joystick.Horizontal * forwardForce;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        /*for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPosition, Color.red);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }*/
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        rb.velocity = new Vector3(joystick.Horizontal * 10, -sidewaysForce * Time.deltaTime);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
