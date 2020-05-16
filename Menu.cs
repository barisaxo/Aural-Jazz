using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{

    public GM gm;
    public Material mat;
    Sprite spri;
    // Start is called before the first frame update
    void Start()
    {
        mat = gm.gmSub.mat;
        spri = gm.gmSub.spri;
        
       // MakeMenu();
    }


    void MakeMenu()
    {
        SpriteRenderer sr = gameObject.AddComponent<SpriteRenderer>();
        sr.sprite = spri;
        sr.color = new Color(.85f, .85f, .85f, .35f);
        gameObject.AddComponent<Button>();
        gameObject.AddComponent<BoxCollider2D>().size = new Vector2(gm.gui.horizontal * 2, gm.cam.orthographicSize * 2);
    }


        // Update is called once per frame
        void Update()
    {
        
    }
}
