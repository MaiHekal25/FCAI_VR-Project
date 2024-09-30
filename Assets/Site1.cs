using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Site1 : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Site2");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Top");
        }
    }
}
