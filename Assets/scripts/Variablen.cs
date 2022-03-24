using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variablen : MonoBehaviour
  
{
    public Color farbe;
    GameObject x;
    

    // Start is called before the first frame update
    void Start()
    {
        farbe = Color.red;
        Debug.Log("Red " + farbe.ToString());

        farbe = Color.yellow;
        Debug.Log("Yellow " + farbe.ToString());

        farbe = Color.white;
        Debug.Log("Yellow" + farbe.ToString());


        Debug.Log(x.ToString());

        int anzTueren = int.Parse("4");
        float anzTueren = float.Parse("4");
        Debug.Log(anzTueren + " " + anzTuerenF + " " + amzTuerenInstanz);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
