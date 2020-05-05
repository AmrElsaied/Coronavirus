using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class btn : MonoBehaviour
{

    [SerializeField]
    Button bt;
    [SerializeField]
    Image im;
    [SerializeField]
    UnityEvent clk;

    bool state = false;
    float total = 3;
    float now = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state == true)
        {
            now += Time.deltaTime;
            im.fillAmount = now / total;

            if (now > total)
            {
                clk.Invoke();
            }
        }
    }

    public void GvrOnButton()
    {
        state = true;
    }

    public void GvrOffButton()
    {
        state = false;
        im.fillAmount = 0;
        now = 0;
    }
}
