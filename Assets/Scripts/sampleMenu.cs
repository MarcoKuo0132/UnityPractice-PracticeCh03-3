using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleMenu : MonoBehaviour
{
    public GUIStyle btnStyle;

    private Rect btnStartRect;       //rect for button
    private Rect btnLeaveRect;       //rect for button

    // Start is called before the first frame update
    void Start()
    {
        btnStartRect = new Rect();
        btnLeaveRect = new Rect();

        btnStartRect.x = Screen.width / 3;
        btnStartRect.y = Screen.height * 2 / 5;
        btnStartRect.width = Screen.width / 3;
        btnStartRect.height = Screen.height / 5;

        btnLeaveRect.x = Screen.width / 3;
        btnLeaveRect.y = Screen.height * 2 / 5 - 50;
        btnLeaveRect.width = Screen.width / 3;
        btnLeaveRect.height = Screen.height / 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (GUI.Button(btnStartRect, "Start", btnStyle))
        {
            sampleGame g = gameObject.GetComponent<sampleGame>();
            g.enabled = true;
            this.enabled = false;
        }

        if (GUI.Button(btnLeaveRect, "Leave", btnStyle))
        {
            Application.Quit();
        }
    }
}
