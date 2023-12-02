using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpForce;
    Rigidbody rb;
    bool isBoost = true;
    float boost_timer = 0.56f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBoost)
        {
            rb.velocity = new Vector3(0, jumpForce, 0);
            isBoost = false;
        }
        if (boost_timer > 0f && isBoost == false)
        {
            boost_timer -= Time.deltaTime;
            //Debug.Log(boost_timer);
        }
        else
        {
            isBoost = true;
            boost_timer = 0.56f;
        }
        if (rb.transform.position.y > 3f)
        {
            isBoost = false;
        }
    }
}
