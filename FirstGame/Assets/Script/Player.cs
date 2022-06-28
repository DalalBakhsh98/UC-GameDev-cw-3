using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D playerRB;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal")*speed,0f);

        
    }
}
