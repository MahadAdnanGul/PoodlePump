using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{

    float colliderRadius;
    // Start is called before the first frame update
    void Start()
    {
        colliderRadius = (GetComponent<BoxCollider2D>().size.x)/2;
    }

    private void Update()
    {
        if (transform.position.y < Camera.main.transform.position.y-(float)3.58)
        {
            //Debug.Log("ded");
            gameObject.GetComponent<Scene_change>().stop_scene();
        }
   }

    void OnBecameInvisible()
    {
        Debug.Log("invis");
        Vector2 position = transform.position;

        // check left, right, top, and bottom sides
        if (position.x + colliderRadius < ScreenUtils.ScreenLeft ||
            position.x - colliderRadius > ScreenUtils.ScreenRight)
        {
            position.x *= -1;
        }

        


        // move ship
        transform.position = position;
    }
}
