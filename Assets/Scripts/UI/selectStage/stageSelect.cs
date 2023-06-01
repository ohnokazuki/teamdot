using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stageSelect : MonoBehaviour
{
    [SerializeField]
    List<string> targetStages = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load1Stage()
    {
        SceneManager.LoadScene(targetStages[0]);
    }

    public void Load2Stage()
    {
        SceneManager.LoadScene(targetStages[1]);
    }

    public void Load3Stage()
    {
        SceneManager.LoadScene(targetStages[2]);
    }
}
