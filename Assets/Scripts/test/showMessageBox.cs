using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showMessageBox : MonoBehaviour
{

    GameObject background;
    TextMeshPro titleOBJ;
    TextMeshPro contentOBJ;

    string title;
    string textContent;

    // get title and content game obj from children
    private void Start()
    {
        background = GetComponentInChildren<GameObject>();
        titleOBJ = background.GetComponentInChildren<TextMeshPro>();
        contentOBJ = background.GetComponentInChildren<TextMeshPro>();

        Debug.Log("obj in showMessageBox.cs");
        Debug.Log(background.name);
        Debug.Log(titleOBJ.name);
        Debug.Log(contentOBJ.name);
    }

    public void setTitle(string title)
    {
        this.title = title;
        titleOBJ.text = this.title;
    }

    public void setText(string text)
    {
        this.textContent = text;
        contentOBJ.text = textContent;
    }
}
