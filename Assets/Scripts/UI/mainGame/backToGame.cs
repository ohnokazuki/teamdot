using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToGame : MonoBehaviour
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
        
    }

    public void DestoryPauseMenu()
    {
        SceneManager.UnloadSceneAsync(targetScene);
    }
}
