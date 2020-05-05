using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toAR : MonoBehaviour
{
    public float changescenesec = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changescenesec -= Time.deltaTime;
        if (changescenesec <= 1f) {
            SceneManager.LoadScene("AREnterance");
                }
    }
}
