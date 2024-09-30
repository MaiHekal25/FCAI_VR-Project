using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Site13 : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Site14");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("Site12");
        }
    }
}
