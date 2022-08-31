using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public Material material;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1, 0);
        }
        material.SetVector("playerPos", transform.position);
    }
}
