using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementt : MonoBehaviour {

	// Use this for initialization
    public float speed = 40;
    public float jumpforce = 10;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetButton("Vertical1"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce));
        }
        float v = Input.GetAxisRaw("Vertical2") * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0);//

    }
}
