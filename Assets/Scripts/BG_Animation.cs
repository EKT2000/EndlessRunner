using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UnityEngine;

public class BG_Animation : MonoBehaviour
{

    public static float animationspeed = 0.1f; //Geschwindigkeit, mit der sich der Hintergrund bewegt 
    private Material BGmaterial; //material = Objekte, z.B. Background
    private Vector2 offset = Vector2.zero; //Offset/Verschiebung: zu Beginn auf Null gesetzt


    // Start is called before the first frame update
    void Start()
    {
        BGmaterial = GetComponent<Renderer>().material; //auslesen des Materials (z.B. Background) aus dem Renderer
        offset = BGmaterial.GetTextureOffset("_MainTex"); //Textureoffset getten, "_MainTex" beschreibt Eigenschaften des Bildes bei Speicherung. Des Weiteren gibt es Blendtex etc.
        
    }

    // Update is called once per frame
    void Update()
    {
        offset.x = offset.x + animationspeed * Time.deltaTime; //Time.deltatime = Vergangene Zeit bis zur vollständigen Anzeige des letzten Frames
        BGmaterial.SetTextureOffset("_MainTex", offset); //Material bekommt Offset hinzugefügt, offset wird frame für frame größer
        animationspeed = animationspeed + 0.000006f;
        if (PlayerHealth.PlayerAlive == false)
        {
            animationspeed = 0.1f;
        }

    }
}
