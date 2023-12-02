using System;
using System.Collections;
using UnityEngine;

public class OldMovement : MonoBehaviour
{
    [SerializeField] float movement = 2f;
    Rigidbody rb;
    public static event Action moveFinish;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontal * movement, 0f, vertical * movement);
        
    }

    public void spacePressed()
    {
        moveFinish?.Invoke();
    }

    

}
