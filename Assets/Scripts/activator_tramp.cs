using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator_tramp : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.y > gameObject.transform.position.y + 0.133)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (player.transform.position.y < gameObject.transform.position.y-0.1)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

}
