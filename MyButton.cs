using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyButton : MonoBehaviour
{
    public GM gm;
    Sprite spri;

    // Start is called before the first frame update
    void Start()
    {
        spri = gm.gmSub.spri;
        gameObject.AddComponent<SpriteRenderer>().sprite = spri;
        GetComponent<SpriteRenderer>().color = new Color(.85f, .85f, .85f, .35f);
        gameObject.AddComponent<Button>();
        gameObject.AddComponent<BoxCollider2D>().size = new Vector2(.12f, .12f);
    }

}
