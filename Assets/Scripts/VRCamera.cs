using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VRCamera : MonoBehaviour
{


    public float speed = 5.0f;
    public float zoomSpeed = 20.0f;
    private int scrollCount = 0;

    void Update()

    {
        //Moving 360-degree through image
        float mouseX = Input.GetAxis("Mouse X") * speed; //horizontal movement of the mouse to control the rotation speed.
        float mouseY = Input.GetAxis("Mouse Y") * speed; //vertical movement of the mouse to control the rotation speed

        transform.Rotate(-mouseY, mouseX, 0); // -mouseY controlling the rotation around the X axis
                                              // and mouseX controlling the rotation around the Y axis.
                                              // The 0 value means no rotation around the Z axis.
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);//ensures that the object does not rotate around
                                                                                                 //the Z axis.


        // Zoom in and out with the mouse scroll wheel
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        GetComponent<Camera>().fieldOfView -= scroll * zoomSpeed;

        if (scroll != 0)
        {
            scrollCount++;
        }

        // Switch to the next scene when the mouse scroll wheel is scrolled 
        if (scrollCount >= 5)
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (nextSceneIndex >= SceneManager.sceneCountInBuildSettings) // reach the end 
            {
                nextSceneIndex = 0; // load the first scene when reaching the end.
            }
            SceneManager.LoadScene(nextSceneIndex);
            scrollCount = 0;//resets the scrollCount variable to 0 after loading the next scene.
        }
    }
}
