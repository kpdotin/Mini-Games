using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bomb;
    private GameObject bmb;
    private float timer = 30f;
    private Vector3[] vectors = {new Vector3(0, 10f, -3.6f), new Vector3(0, 7.5f, -5f), new Vector3(0, 5.7f, -6.6f), new Vector3(0, 4f, -8.6f) };
    float bombspawn = 4f;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(bombspawn > 0)
        {
            bombspawn -= Time.deltaTime;
        }
        else
        {
            spawn();
            bombspawn = 4f;
        }
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Game Over");
        }
    }

    void spawn()
    {
        int index = Random.Range(0, 4);
        Debug.Log(Random.Range(0, 4));
        Vector3 randomvector = vectors[index];
        bmb = Instantiate(bomb, new Vector3(0.224000007f, 1.38699019f, 3.99000001f), Quaternion.identity);
        bmb.GetComponent<Rigidbody>().velocity = randomvector;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bomb")
        {
            Destroy(collision.gameObject,2f);
        }
    }
}
