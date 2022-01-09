using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    [SerializeField] public float speedTime=1;
    [SerializeField] public Text textSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            speedTime = float.Parse(textSpeed.text);
        }
        catch { }
        
    }
}
