using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Site10 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Site11");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("Site9");
        }
    }
}
