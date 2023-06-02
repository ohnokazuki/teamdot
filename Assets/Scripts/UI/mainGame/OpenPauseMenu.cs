using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenPauseMenu : MonoBehaviour
{
    [SerializeField]
    string targetScene = "pauseMenu";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyInput();
    }

    void KeyInput()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            LoadPauseMenu();
        }
    }

    public void LoadPauseMenu()
    {
        SceneManager.LoadSceneAsync(targetScene);
    }
}
