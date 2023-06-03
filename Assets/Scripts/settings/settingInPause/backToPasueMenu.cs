using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToPasueMenu : MonoBehaviour
{
    [SerializeField]
    string tagName = "SettingInPauseMenu";


    public void DestorySettingUI()
    {
        GameObject []targets = GameObject.FindGameObjectsWithTag(tagName);
        foreach (var item in targets)
        {
            Destroy(item);
        }
    }
}
