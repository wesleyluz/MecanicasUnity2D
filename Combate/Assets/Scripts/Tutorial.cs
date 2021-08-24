using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;


public class Tutorial : MonoBehaviour
{
    private Text texto;
    private String algo;
    private int i = 2;
    private JsonData dialogo;
    // Start is called before the first frame update
    void Start()
    {
        TextAsset text = Resources.Load<TextAsset>("Text/Dialogo 1");
        algo = text.text;
        dialogo = JsonMapper.ToObject(algo);
        print(dialogo[i]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
