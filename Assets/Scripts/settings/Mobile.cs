using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mobile : MonoBehaviour
{

    // keep values which can be set in setting scene.
    static public bool TouchControler = false;
    

    private void Start()
    {
        var touchSettting = GameObject.FindObjectsOfType<Toggle>();
        foreach(Toggle toggle in touchSettting)
        {
            if(toggle.name == "Touch")
            {
                toggle.isOn = TouchControler ? true : false;
                Debug.Log("Start init is ok");
            }
        }
    }


    public void touchEnableAndDisable()
    {
        var touchSettting = GameObject.FindObjectsOfType<Toggle>();
        foreach (Toggle toggle in touchSettting)
        {
            if (toggle.name == "Touch")
            {
                TouchControler = toggle.isOn ? true : false;
            }
        }
        Debug.Log("TouchControler value is " + TouchControler);
    }

}
