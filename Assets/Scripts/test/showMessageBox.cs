using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showMessageBox : MonoBehaviour
{
    [SerializeField]
    GameObject background;
    [SerializeField]
    GameObject titleOBJ;
    [SerializeField]
    GameObject contentOBJ;

    TextMeshPro titleMesh;
    TextMeshPro contentMesh;

    string title;
    string textContent;

    // get title and content game obj from children
    private void Start()
    {
        Debug.Log("obj in showMessageBox.cs");
        Debug.Log(background.name);
        Debug.Log(titleOBJ.name);
        Debug.Log(contentOBJ.name);


        titleMesh = titleOBJ.GetComponent<TextMeshPro>();
        contentMesh = contentOBJ.GetComponent<TextMeshPro>();
    }

    public void setTitle(string title)
    {
        this.title = title;
        titleMesh.text = this.title;
    }

    public void setText(string text)
    {
        this.textContent = text;
        contentMesh.text = textContent;
    }
}
