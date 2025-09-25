using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private readonly Rigidbody rb;
    public float speed = 10f;
    // Start is called before the first frame update
    private bool isGrounded = true;
    void Start()
    {
        Debug.Log("Movement script started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += speed * Time.deltaTime * Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += speed * Time.deltaTime * Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += speed * Time.deltaTime * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += speed * Time.deltaTime * Vector3.back;
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            transform.position += speed * Time.deltaTime * Vector3.up;
        }
        //else
        //{
        //    transform.position += speed * Time.deltaTime * Vector3.down;
        //}



    }
    //public void FixedUpdate()
    //{
    //    if (Input.GetKey(KeyCode.Space) && isGrounded)
    //    {
    //        transform.position += speed * Time.deltaTime * Vector3.up;
    //    }
    //    else
    //    {
    //        transform.position += speed * Time.deltaTime * Vector3.down;
    //    }
    //}
}
