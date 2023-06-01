using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    [SerializeField]
    string gameSelect = "selectStage";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadStageSelect()
    {
        SceneManager.LoadScene(gameSelect);
    }
}
