using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeMessageBox : MonoBehaviour
{
    [SerializeField]
    GameObject MessgeBox;

    public void close()
    {
        MessgeBox.SetActive(false);
    }
}
