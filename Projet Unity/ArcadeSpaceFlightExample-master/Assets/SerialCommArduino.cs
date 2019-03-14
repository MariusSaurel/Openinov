using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class SerialCommArduino : MonoBehaviour
{
    SerialPort arduino;
    float rotationx;
    float rotationy;

    // Start is called before the first frame update
    void Start()
    {
        arduino = new SerialPort("COM5", 9600);
        arduino.Open();
    }

    // Update is called once per frame
    void Update()
    {
        if (arduino.IsOpen)
        {
                arduino.Write(rotationx + "|" + rotationy );
                Debug.Log(1);
        }
    }
}
