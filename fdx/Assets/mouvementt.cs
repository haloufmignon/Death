using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouvementt : MonoBehaviour {

	// Use this for initialization
    public float speed = 40;
    public float jumpforce = 10;
    public static float healthAmount;
    void Start()
    {
        healthAmount = 10;

    }

    void Update()
    {
        if (healthAmount == 20)
            Destroy(gameObject);
        if (healthAmount == 0)
        {
            loadin();

        }
    }  //
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
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("bonus"))
            healthAmount += 2;
    
        if (collider.gameObject.tag.Equals("piege"))
            healthAmount -= 2;
    }
    public void loadin()
    {
        SceneManager.LoadScene(2);

} 
}
