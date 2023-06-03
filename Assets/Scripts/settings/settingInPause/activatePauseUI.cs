using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatePauseUI : MonoBehaviour
{
    public void activatePauseUIFunc()
    {
        GameObject[] pause = GameObject.FindGameObjectsWithTag("pauseMenu");
        foreach (var item in pause)
        {
            item.SetActive(true);
        }
    }
}
