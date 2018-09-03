using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouvement : MonoBehaviour {

    public float speed = 40;
    public float jumpforce = 10;
    public static float healthAmount;
    void Start(){
        healthAmount = 10;
   
    }
    void Update(){
        if (healthAmount ==20)
            Destroy(gameObject);

        if (healthAmount==0)
        {
            loading();

        }
    }  // Update is called once per frame
	void FixedUpdate () {

        if (Input.GetButton("Jump"))
       {   
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce));
        } 
             float v = Input.GetAxisRaw("Horizontal" ) * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0);//
   
}
    void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject.tag.Equals("bonus"))
            healthAmount += 2;
    
        if (collider.gameObject.tag.Equals("piege"))
            healthAmount -= 2;
    } 

    public void loading()
    {
        SceneManager.LoadScene(1);

} 
}
