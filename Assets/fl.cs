using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fl : MonoBehaviour
{   Vector3 turn2;
    // Start is called before the first frame update
    void Start()
    {
        turn2 = new Vector3(0, 15, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {

            transform.Rotate(turn2 * Time.deltaTime * 1f);
        }
    }
}
