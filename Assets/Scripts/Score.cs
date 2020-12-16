using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject doodler;
    float score = 0;
    float score80 = 0;
    string final;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void FixedUpdate()
    {
        if(doodler.transform.position.y>score)
        {
            score = doodler.transform.position.y;
            score80 = (int)(score * 80);
            final = score80.ToString();
            text.text = final;
        }
    }
}
