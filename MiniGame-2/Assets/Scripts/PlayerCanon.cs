using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanon : MonoBehaviour
{
    float health = 99f;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bomb")
        {
            Debug.Log("Hit");
            health -= 33f;
            Debug.Log(health);
        }
    }
    private void Update()
    {
        if(health == 0)
        {
            Debug.Log("Game Over");
        }
    }
}
