using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleGame : MonoBehaviour
{
    public GUISkin skin;    //GUISkin for GUI style controller
    public GameObject tex;

    private Rect lblRect;   //Rect for label
    private Rect btnClearRect;   //Rect for Clear button
    private Rect btnEndRect;   //Rect for End button

    private List<GameObject> texs;

    // Start is called before the first frame update
    void Start()
    {
        lblRect = new Rect();
        btnClearRect = new Rect();
        btnEndRect = new Rect();

        texs = new List<GameObject>();

        lblRect.x = 0;
        lblRect.y = Screen.height - 30;
        lblRect.width = 100;
        lblRect.height = 30;

        btnClearRect.x = 0;
        btnClearRect.y = 0;
        btnClearRect.width = 100;
        btnClearRect.height = 100;

        btnEndRect.x = 0;
        btnEndRect.y = 145;
        btnEndRect.width = 100;
        btnEndRect.height = 45;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.x /= Screen.width;
            pos.y /= Screen.height;

            GameObject g = (GameObject)Instantiate(tex, pos, Quaternion.identity);

            texs.Add(g);
        }
    }

    void OnGUI()
    {
        GUI.Label(lblRect, "0",skin.label);

        if (GUI.Button(btnClearRect, "Clear", skin.button))
        {
            foreach (GameObject g in texs)
            {
                Destroy(g, 0);
            }
            texs.Clear();
        }

        if (GUI.Button(btnEndRect, "End", skin.button))
        {
            foreach (GameObject g in texs)
            {
                Destroy(g, 0);
            }
            texs.Clear();

            sampleMenu m = gameObject.GetComponent<sampleMenu>();
            m.enabled = true;
            this.enabled = false;
        }
    }
}
