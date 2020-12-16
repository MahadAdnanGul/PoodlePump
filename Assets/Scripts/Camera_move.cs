using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    public Vector3 rate = new Vector3(0,4,0);
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player.transform.position.y>gameObject.transform.position.y)
        {
            Vector3 temp = gameObject.transform.position;
            temp += rate * Time.deltaTime;
            gameObject.transform.position = temp;
        }
    }
}
