using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Site14 : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Site2");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("Site13");
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Top");
        }
    }
}
