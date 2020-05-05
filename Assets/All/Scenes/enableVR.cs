using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class enableVR : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        XRSettings.LoadDeviceByName("Cardboard");
        XRSettings.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
 
}
