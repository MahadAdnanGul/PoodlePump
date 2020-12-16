using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanup : MonoBehaviour
{
    
    int gencount;
    public int final_gen = 0;
    // Start is called before the first frame update
    private void Start()
    {
        gencount= Camera.main.GetComponent<generator>().gen_called;
    }
    private void Update()
    {
        if (Camera.main.GetComponent<generator>().gen_called > gencount)
        {
            final_gen++;
            gencount++;

        }
        if(final_gen>=4)
        {
            Destroy(gameObject);
        }
         
    }

    
   
}
