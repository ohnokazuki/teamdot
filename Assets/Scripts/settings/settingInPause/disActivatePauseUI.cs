using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disActivatePauseUI : MonoBehaviour
{
    private void Start()
    {
        GameObject []pause = GameObject.FindGameObjectsWithTag("pauseMenu");
        foreach (var item in pause)
        {
            item.SetActive(false);
        }
    }
}
