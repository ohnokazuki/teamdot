using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changePlayerSpeed : MonoBehaviour
{
    public void changePlayerSpeedBySlider(Slider slider)
    {
        player.speed = slider.value;
        Debug.Log("Player speed is changed to " +  player.speed);

        //Find showPlayerSpeed and get text component.
        //After that, set text to player speed
        GameObject []showSpeed = GameObject.FindGameObjectsWithTag("UI");
        foreach (GameObject go in showSpeed)
        {
            if(go.name == "showPlayerSpeed")
            {
                Text speedText = go.GetComponent<Text>();
                speedText.text = player.speed.ToString();
                Debug.Log("Set value correctly");
            }
        }

    }
}
