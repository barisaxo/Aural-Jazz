using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGUI : MonoBehaviour
{
    public GM gm;
    public Material mat;
    public float vertical, horizontal;
    Camera cam;
    Vector3 vec;
    public Transform chordPanel;

    // Start is called before the first frame update
    void Start()
    {
        mat = gm.gmSub.mat;

        cam = gm.cam.GetComponent<Camera>();
        // vertical = cam.GetComponent<Camera>().orthographicSize;
        // horizontal = vertical * (Screen.width / Screen.height);
        vertical = (float)cam.orthographicSize * (float)((float)Screen.height / (float)Screen.width);
        horizontal = (float)cam.orthographicSize * (float)((float)Screen.width / (float)Screen.height);

        chordPanel = new GameObject("Chord Panel").transform;
        chordPanel.SetParent(gameObject.transform);

        EightBar();
    }

    void EightBar()
    {
        //double bar
        DrawLine(new Vector3(-horizontal + .1f, vertical - (vertical * .6f), 0),
            new Vector3(-horizontal + .1f, vertical + (vertical * .4f), 0), .14f);

        //measure one
        DrawLine(vec = new Vector3(-horizontal + (horizontal * .035f), vertical - (vertical * .6f), 0),
            new Vector3(-horizontal + (horizontal * .035f), vertical + (vertical * .4f), 0), .08f);
        MakeButton(new Vector3(vec.x + (horizontal * .125f), vec.y + (vertical * .5f), 0), "Button1A");

        //measure two
        DrawLine(vec = new Vector3(-horizontal + (.515f * horizontal), vertical - (vertical * .6f), 0),
             new Vector3(-horizontal + (.515f * horizontal), vertical + (vertical * .4f), 0), .1f);
        MakeButton(new Vector3(vec.x - (horizontal * .125f), vec.y + (vertical * .5f), 0), "Button1B");
        MakeButton(new Vector3(vec.x + (horizontal * .125f), vec.y + (vertical * .5f), 0), "Button2A");

        //measure three
        DrawLine(vec = new Vector3(0, vertical - (vertical * .6f), 0),
            new Vector3(0, vertical + (vertical * .4f), 0), .1f);
        MakeButton(new Vector3(vec.x - (horizontal * .125f), vec.y + (vertical * .5f), 0), "Button2B");
        MakeButton(new Vector3(vec.x + (horizontal * .125f), vec.y + (vertical * .5f), 0), "Button3A");

        //measure 4
        DrawLine(vec = new Vector3(horizontal - (.515f * horizontal), vertical - (vertical * .6f), 0),
            new Vector3(horizontal - (.515f * horizontal), vertical + (vertical * .4f), 0), .1f);
        MakeButton(new Vector3(vec.x - (horizontal * .125f), vec.y + (vertical * .5f), 0), "Button3B");
        MakeButton(new Vector3(vec.x + (horizontal * .125f), vec.y + (vertical * .5f), 0), "Button4A");

        //close 
        DrawLine(vec = new Vector3(horizontal - (horizontal * .035f), vertical - (vertical * .6f), 0),
           new Vector3(horizontal - (horizontal * .035f), vertical + (vertical * .4f), 0), .1f);
        MakeButton(new Vector3(vec.x - (horizontal * .125f), vec.y + (vertical * .5f), 0), "Button4B");


        //measures 5
        DrawLine(vec = new Vector3(-horizontal + (horizontal * .035f), -vertical + (vertical * .6f), 0),
            new Vector3(-horizontal + (horizontal * .035f), -vertical - (vertical * .4f), 0), .1f);
        MakeButton(new Vector3(vec.x + (horizontal * .125f), vec.y - (vertical * .5f), 0), "Button5A");

        //measure 6
        DrawLine(vec = new Vector3(-horizontal + (.515f * horizontal), -vertical + (vertical * .6f), 0),
             new Vector3(-horizontal + (.515f * horizontal), -vertical - (vertical * .4f), 0), .1f);
        MakeButton(new Vector3(vec.x - (horizontal * .125f), vec.y - (vertical * .5f), 0), "Button5B");
        MakeButton(new Vector3(vec.x + (horizontal * .125f), vec.y - (vertical * .5f), 0), "Button6A");

        //measure 7
        DrawLine(vec = new Vector3(0, -vertical + (vertical * .6f), 0),
            new Vector3(0, -vertical - (vertical * .4f), 0), .1f);
        MakeButton(new Vector3(vec.x - (horizontal * .125f), vec.y - (vertical * .5f), 0), "Button6B");
        MakeButton(new Vector3(vec.x + (horizontal * .125f), vec.y - (vertical * .5f), 0), "Button7A");

        //measure 8
        DrawLine(vec = new Vector3(horizontal - (.515f * horizontal), -vertical + (vertical * .6f), 0),
            new Vector3(horizontal - (.515f * horizontal), -vertical - (vertical * .4f), 0), .1f);
        MakeButton(new Vector3(vec.x - (horizontal * .125f), vec.y - (vertical * .5f), 0), "Button7B");
        MakeButton(new Vector3(vec.x + (horizontal * .125f), vec.y - (vertical * .5f), 0), "Button8A");

        //Close 8
        DrawLine(vec = new Vector3(horizontal - (horizontal * .035f), -vertical + (vertical * .6f), 0),
           new Vector3(horizontal - (horizontal * .035f), -vertical - (vertical * .4f), 0), .08f);
        MakeButton(new Vector3(vec.x - (horizontal * .125f), vec.y - (vertical * .5f), 0), "Button8B");

        //Double Bar end
        DrawLine(new Vector3(horizontal - .1f, -vertical + (vertical * .6f), 0),
             new Vector3(horizontal - .1f, -vertical - (vertical * .4f), 0), .14f);
    }

    void TwelveBar()
    {

    }

    void MakeButton(Vector3 pos, string named)
    {
        MyButton b = new GameObject(named).AddComponent<MyButton>();
        b.gm = gm;
        b.transform.position = pos;
        b.transform.localScale = new Vector3(horizontal *1.5f, vertical *7f, 0);
        b.transform.SetParent(chordPanel);
    }

    void DrawLine(Vector3 start, Vector3 end, float lineWidth)
    {
        GameObject myLine = new GameObject("Line");
        myLine.transform.position = start;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        lr.material = mat;
        lr.startColor = new Color(1, 1, 1, 1);
        lr.endColor = new Color(1, 1, 1, 1);
        lr.startWidth = lineWidth;
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
        myLine.transform.SetParent(chordPanel);
    }
}
