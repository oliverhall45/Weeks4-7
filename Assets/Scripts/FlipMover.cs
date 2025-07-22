using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FlipMover : MonoBehaviour
{
    public float speed;
    public float direction = 1f;

    public bool moveClick;
    public bool stopClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveClick)
        {
            transform.position += Vector3.right * speed * Time.deltaTime * direction;
        }

        if (stopClick)
        {
            moveClick = false;
        }
    }

    public void OnMoveClick()
    {
        Debug.Log("Move was Clicked");

        moveClick = true;

    }

    public void OnStopClick()
    {
        Debug.Log("Stop was Clicked");

        stopClick = true;
    }

    public void OnFlipClick()
    {
        direction *= -1f;
    }

}
