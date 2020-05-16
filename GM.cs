using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public MyCamera myCam;
    public MyCanvas canvas;
    public MyGUI gui;
    public Camera cam;
    public Menu menu;
    public GM gm;
    public GMSub gmSub;

    void Start()
    {
        gm = GetComponent<GM>();

        gmSub = gameObject.AddComponent<GMSub>();
        gmSub.gm = gm;

        myCam = new GameObject("Camera").AddComponent<MyCamera>();
        myCam.gm = gm;
        
        //canvas = new GameObject("Canvas").AddComponent<MyCanvas>();
        //canvas.gm = gm;

        gui = new GameObject("GUI").AddComponent<MyGUI>();
        gui.gm = gm;

        menu = new GameObject("Menu").AddComponent<Menu>();
        menu.gm = gm;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            //Debug.Log(ray);
            if (hit.collider != null)
            {
               hit.collider.gameObject.SetActive(false);
               StartCoroutine(ReEnable(hit.collider.gameObject));
            }
        }
    }

    IEnumerator ReEnable(GameObject hit)
    {
        yield return new WaitForSeconds(.5f);
        hit.SetActive(true);
    }

}

/*
 *
 *
 *Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

    RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
 * 
 * */
