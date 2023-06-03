using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMobileUI : MonoBehaviour
{
    [SerializeField]
    string MobileUIScene = "MobileUI";
    // Start is called before the first frame update
    void Start()
    {
        if (Mobile.TouchControler)
        {
            SceneManager.LoadScene(MobileUIScene);
        }
    }

}
