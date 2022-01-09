using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageCamera : MonoBehaviour
{
    [SerializeField] public Camera corps;

    [SerializeField] public string tagCamera="MainCamera";

    [SerializeField] public Vector3 positionInit;

    public void appui()
    {
        //meme Corps
        /*
        foreach(GameObject g in GameObject.FindGameObjectsWithTag(tagCamera))
        {
            Debug.Log(g.transform.name);
            Debug.Log(g.name==corps.name);
        }
        */

        if ( GameObject.FindGameObjectsWithTag(tagCamera)[0].name==corps.name )
        {
              corps.transform.position = transform.position + positionInit;
            
            
        }
        else
        {
            GameObject.FindGameObjectsWithTag(tagCamera)[0].gameObject.SetActive(false);
            corps.gameObject.SetActive(true);
        }
    }

}
