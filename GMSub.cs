using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMSub : MonoBehaviour
{
    public GM gm;
    public Material mat;
    public Sprite spri;
    public Font arialFont;

    private void Start()
    {
        mat = new Material(Shader.Find("Legacy Shaders/Particles/Alpha Blended Premultiply"));
        spri = UnityEditor.AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
        arialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
    }


}
