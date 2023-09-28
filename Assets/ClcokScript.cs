using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClcokScript : MonoBehaviour
{

    int hour;
    int minute;
    int second;
    float milliseconds;

    float analogHourRotation;
    float analogMinuteRotation;
    float analogSecondRotation;
    float analogPendulumRotation;
    public string gOTag;
    // Start is called before the first frame update
    void Start()
    {
        gOTag = this.gameObject.tag;

        switch (1)
        {
            case 1:
                Console.WriteLine("HI");
                break;
        }

        Rotate();
    }

    // Update is called once per frame
    void Update()
    {
        hour = DateTime.Now.Hour;
        minute = DateTime.Now.Minute;
        second = DateTime.Now.Second;
        milliseconds = DateTime.Now.Millisecond;
        

        analogHourRotation = hour * -360 / 12;
        analogMinuteRotation = minute * -360 / 60;
        analogSecondRotation = second * -360 / 60;
        analogPendulumRotation =  10  * Mathf.Sin((second + milliseconds / 1000 )* Mathf.PI / 2f);

        Debug.Log(analogPendulumRotation);
        Rotate();

    }

    public void Rotate()
    {
        

        switch (gOTag.ToUpper())
        {
            case "SECONDHND":
               
                this.gameObject.transform.eulerAngles = new Vector3( analogSecondRotation, 0.0f, 0.0f);
            break;

            case "MINUTEHND":
               
                this.gameObject.transform.eulerAngles = new Vector3( analogMinuteRotation, 0.0f, 0.0f);
                break;

            case "HOURHND":
               
                this.gameObject.transform.eulerAngles = new Vector3( analogHourRotation, 0.0f, 0.0f);
                break;

            case "PENDULUM":
                this.gameObject.transform.eulerAngles = new Vector3( 0.0f,-90.0f, analogPendulumRotation);
                break;

            default:
                Debug.Log($"This object <{this.name}> has no recognizable tag for a clock");
                break;
            

            
        }

        Debug.Log("Switch Done?");
    }
}
