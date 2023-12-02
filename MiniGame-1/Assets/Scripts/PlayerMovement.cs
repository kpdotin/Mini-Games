using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool stun;
    private Rigidbody rb;
    private float starttime;
    private float gametime;
    private float timer = 3f;
    [SerializeField] private float movementSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stun)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                stun = false;
                Debug.Log(stun);
                timer = 3f;
            }
        }
        else
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        }

        if (BallMovement.gameover == true)
        {
            gametime = Time.time - starttime;
            Debug.Log(gametime);
            Debug.Log("Game Over");
            //move to next scene after this

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            stun = true;
            Debug.Log(stun);
        }
    }
}
