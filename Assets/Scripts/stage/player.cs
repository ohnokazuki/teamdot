using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public bool isArea;

    [SerializeField]
    static public float speed = 5.0f;
    [SerializeField]
    float timeScaleForSlowMotion = 0.5f;
    float originalTimeScale;
    float modifiedTimeScale;

    static public string currentStage = "";
    static public string nextStage = "";
    static public int killedEnemy = 0;

    static public Vector3 itemPlace = Vector3.zero;

    // keep items which player have
    static public List<string> items;

    static public bool movable = true;


    static public Transform playerTrans;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalTimeScale = Time.timeScale;
        modifiedTimeScale = Time.timeScale * timeScaleForSlowMotion;
        playerTrans = transform;
        items = new List<string>();

        //Load mobile UI settings
        gameObject.AddComponent<LoadMobileUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Operation();
        slowMotion();
        KeyInput();
        rb.velocity = Vector2.zero;
    }

    void Operation()
    {
        if (movable)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                transform.position += transform.up * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                transform.position -= transform.up * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                transform.position += transform.right * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                transform.position -= transform.right * speed * Time.deltaTime;
        }
    }

    void slowMotion()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Time.timeScale = modifiedTimeScale;
        }
        else
        {
            Time.timeScale = originalTimeScale;
        }
    }

    void KeyInput()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            LoadPauseMenu();
        }
    }

    public void LoadPauseMenu()
    {
        SceneManager.LoadSceneAsync("pauseMenu");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("working ");
        if (collision.name == "ƒhƒA(2–‡)")
        {
            items.ForEach(item =>
            {
                if (item == "card key")
                {
                    SceneManager.LoadScene("GameClear");
                    movable = false;
                }
            });
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "DangerArea")
        {
            isArea = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "DangerArea")
        {
            isArea = false;
        }
    }
}
