using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public GameObject tramp;
    public int gen_called=0;
    public GameObject platform;
    public GameObject background;
    float max_distance1 =(float)2.4;
    float current_thresh = (float)14.32;
    float platform_offset;
    
    // Start is called before the first frame update
    void Start()
    {
        //gen();
        platform_offset = (platform.GetComponent<BoxCollider2D>().size.x) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>=current_thresh-(float)7.18)
        {
            gen(current_thresh);
            current_thresh += (float)7.16;
        }
    }

    void gen(float current_thr)
    {
        
        gen_called++;
        
        float max_distance = max_distance1;
        float current_y = (float)-3.5;
        float rando=(float)-3.5;
        float rando2;
        GameObject back = Instantiate(background, new Vector3(0, current_thresh+(float)3.58, 0), Quaternion.identity) as GameObject;
        int n_bricks = Random.Range(5, 10);
        int number;
        GameObject tramps;
        bool trampo = false;
        int tramp_index;
        number = Random.Range(0, 100);
        if (number < 30)
        {
            trampo = true;
            tramp_index = Random.Range(0, n_bricks - 1);
        }
        if (n_bricks>6)
        {
            max_distance =(float) 2;
        }
        else if (n_bricks > 8)
        {
            max_distance = (float)1.8;
        }
        GameObject[] bricks=new GameObject[n_bricks];
        for(int x=0;x<n_bricks;x++)
        {
            
           if(x>n_bricks/2)
            {
                if(current_y<0)
                    current_y = 0;
            }
           if(x==0)
            {
                
                bricks[x] = Instantiate(platform, new Vector3(0, current_thresh + (float)3.58, 0), Quaternion.identity) as GameObject;
                bricks[x].transform.parent = back.transform;
                rando = Random.Range(current_y + (float)0.6, current_y + (float)0.6);
                rando2 = Random.Range(ScreenUtils.ScreenLeft + platform_offset, ScreenUtils.ScreenRight - platform_offset);
                bricks[x].transform.localPosition = new Vector3(rando2, rando, 0);
                if (trampo == true)
                {
                    tramps= Instantiate(tramp, new Vector3(0, current_thresh + (float)3.58, 0), Quaternion.identity) as GameObject;
                    tramps.transform.parent = back.transform;
                    tramps.transform.localPosition = new Vector3(rando2, rando + (float)0.18, 0);
                    trampo = false;
                }

                current_y = rando;
                continue;
            }
            if (x == n_bricks-1)
            {
                bricks[x] = Instantiate(platform, new Vector3(0, current_thresh + (float)3.58, 0), Quaternion.identity) as GameObject;
                bricks[x].transform.parent = back.transform;
                rando = Random.Range((float)2,(float)2.1);
                rando2 = Random.Range(ScreenUtils.ScreenLeft + platform_offset, ScreenUtils.ScreenRight - platform_offset);
                bricks[x].transform.localPosition = new Vector3(rando2, rando, 0);
                if (trampo == true)
                {
                    tramps = Instantiate(tramp, new Vector3(0, current_thresh + (float)3.58, 0), Quaternion.identity) as GameObject;
                    tramps.transform.parent = back.transform;
                    tramps.transform.localPosition = new Vector3(rando2, rando+(float)0.18, 0);
                    trampo = false;
                }
                current_y = rando;
                continue;
            }
            bricks[x] = Instantiate(platform, new Vector3(0, current_thresh + (float)3.58, 0), Quaternion.identity) as GameObject;
           bricks[x].transform.parent = back.transform;
           rando = Random.Range(current_y+(float)1.2, current_y + max_distance);
           rando2 = Random.Range(ScreenUtils.ScreenLeft + platform_offset, ScreenUtils.ScreenRight - platform_offset);
           bricks[x].transform.localPosition = new Vector3(rando2, rando, 0);
            if (trampo == true)
            {
                tramps = Instantiate(tramp, new Vector3(0, current_thresh + (float)3.58, 0), Quaternion.identity) as GameObject;
                tramps.transform.parent = back.transform;
                tramps.transform.localPosition = new Vector3(rando2, rando+(float)0.18, 0);
                trampo = false;
            }
            current_y = rando; 

        }
        
        //GameObject brick = Instantiate(platform, new Vector3(0, 30, 0), Quaternion.identity) as GameObject;
       // brick.transform.parent = back.transform;
       // brick.transform.localPosition = new Vector3(Random.Range(ScreenUtils.ScreenLeft,ScreenUtils.ScreenRight), (float)-3.5, 0);
       // GameObject brick2 = Instantiate(platform, new Vector3(0, 30, 0), Quaternion.identity) as GameObject;
       // brick2.transform.parent = back.transform;
       // brick2.transform.localPosition = new Vector3(Random.Range(ScreenUtils.ScreenLeft, ScreenUtils.ScreenRight), Random.Range((float)-2.5,(float)-1.5), 0);

    }
}
