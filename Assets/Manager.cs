using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject directionalLight;
    public float newdirection;

    // Update is called once per frame
    void Update()
    {
        newdirection += 10f;
        directionalLight.transform.Rotate(0.1f, 0.0f, 0.0f, Space.World);
        //if(Input.GetKeyDown("q"))
       // {
        //    SceneManager.LoadScene(0);
        //}
    }
}
