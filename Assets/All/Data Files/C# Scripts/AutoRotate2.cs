using UnityEngine;
using System.Collections;

namespace RockVR.Video.Demo
{
    public class AutoRotate2 : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // Rotate the object around its local X axis at 100 degree per second
            transform.Rotate(Vector3.right * Time.deltaTime * 80);

            // ...also rotate around the World's Y axis
            transform.Rotate(Vector3.up * Time.deltaTime * 80, Space.World);
        }
    }
}