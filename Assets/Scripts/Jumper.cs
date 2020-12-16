using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Animator anim;
    public AudioSource jump;
    public AudioClip jumper;
    public AudioClip tramp;
    public GameObject doodle_sprite;
    float inp;
    float fin;
    Vector3 final;
    Vector3 temp;
   

    //static float spd = 6;
    Vector3 rate = new Vector3((float)4, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




         inp = Input.acceleration.x;
         fin = rate.x * inp;
         final = new Vector3((float)6 * fin, 0, 0);
       // Debug.Log(inp);
        if (inp > 0)
        {
            if(inp>0.05)
                doodle_sprite.GetComponent<SpriteRenderer>().flipX = false;


            temp = gameObject.transform.position;
            temp += final * Time.deltaTime;
            gameObject.transform.position = temp;
        }
        else if (inp < 0)
        {
            if (inp < -0.05)
                doodle_sprite.GetComponent<SpriteRenderer>().flipX = true;
            temp = gameObject.transform.position;
            temp += final * Time.deltaTime;
            gameObject.transform.position = temp;
        }

    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetBool("Tramp", false);
        Camera.main.GetComponent<Camera_move>().rate = new Vector3(0, 4, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0;
        if (collision.gameObject.tag=="platform")
        {
            jump.PlayOneShot(jumper);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
        }
        else if(collision.gameObject.tag=="tramp")
        {
            anim.SetBool("Tramp", true);
            jump.PlayOneShot(tramp);
            Camera.main.GetComponent<Camera_move>().rate = new Vector3(0, 8, 0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 14), ForceMode2D.Impulse);
        }
    }
}
