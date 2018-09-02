using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marchejump : MonoBehaviour {
    public float speed = 40;
    public float jumpforce = 10;
    // Use this for initialization
    void FixesdUpdate()
    {
        if (Input.GetButton("Jump")   )   {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce));

        }
        float v = Input.GetAxisRaw("Horizontal") * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0);


        // Update is called once per frame

    }

}