using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public GM gm;
    Camera cam;


    void Start()
    {
        cam = gameObject.AddComponent<Camera>();
        gm.cam = GetComponent<Camera>();
        cam.transform.position = new Vector3(0, 0, -10);
        cam.orthographic = true;
        cam.orthographicSize = 4;
        cam.backgroundColor = new Color(Random.Range(.01f, .1f),
            Random.Range(.01f, .1f), Random.Range(.01f, .1f), 1f);
    }

}
/*
 *IMPORTANT INFO
 * vertical is always 2x orthographic size
 * vertical scale is always 50
 *
 *
 *
 *
 */