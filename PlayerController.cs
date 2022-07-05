using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float verticalInput;
    public float speed = 7.0f;
    public Rigidbody rb;
    public string midJump = "no";
    public float xBorder = 5f;
    public float jumpReset = 0.05f;
    public float jumpHeight = 5.5f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xBorder)
        {
            transform.position = new Vector3(xBorder, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xBorder)
        {
            transform.position = new Vector3(-xBorder, transform.position.y, transform.position.z);
        }


        //Moves player side to side (horizontal axis)
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Player jumps when space is pressed
        if (Input.GetKeyDown(KeyCode.Space) && (midJump == "no"))

        {
            rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            midJump = "yes";

        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        //Returns string to "no" when the player reaches the ground which stops double jumping
        if (collision.gameObject.tag == "Floor")
        {
            midJump = "no";
        }
    }


}
