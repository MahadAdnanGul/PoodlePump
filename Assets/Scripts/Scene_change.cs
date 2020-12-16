using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change : MonoBehaviour
{
    // Start is called before the first frame update
  

    // Update is called once per frame
   

   public void play_scene()
    {
        SceneManager.LoadScene(1);
    }
    public void stop_scene()
    {
        SceneManager.LoadScene(0);
    }
}
