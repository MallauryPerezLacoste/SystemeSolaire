using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corps : MonoBehaviour
{
    [SerializeField] public float UA = 10;

    [SerializeField] public string Nom;

    [SerializeField] public GameObject Centre;
    [SerializeField] public Vector3 Position=new Vector3(1,0,0);
    [SerializeField] public float Distance;

    [SerializeField] public float Rayon;
    [SerializeField] public float Masse;

    [SerializeField] public float Revolution;
    [SerializeField] public float Rotation;

    private GameObject timeObject;
    private Vector3 centrePosition=new Vector3(0,0,0); 
    

    void Start()
    {
        transform.name=Nom;
        placerCorps();
        creerCorps();
        timeObject = GameObject.FindGameObjectsWithTag("timeObject")[0];

        if (Centre != null)
        {
            centrePosition=Centre.transform.position;   
        }

    }

    private void placerCorps()
    {
        if(Position!=new Vector3(0, 0, 0))
        {
            Vector3 vecteurNormalise = Position.normalized;
            if (Centre != null)
            {
                transform.position = Centre.transform.position + vecteurNormalise * (Distance*UA+Centre.GetComponent<Corps>().Rayon);
            }
            else
            {
                transform.position = vecteurNormalise * Distance*UA;
            }
        }
    }

    private void creerCorps()
    {
        transform.localScale = new Vector3(Rayon*2,Rayon*2,Rayon*2);
        gameObject.GetComponent<Rigidbody>().mass = Masse;
    }

    // Update is called once per frame
    void Update()
    {
        if (Revolution != 0)
        {
            float angle = (360 / Revolution) * timeObject.GetComponent<time>().speedTime;


            if (centrePosition != transform.position)
            {
                transform.RotateAround(centrePosition, Vector3.up, -angle * Time.deltaTime);
            }
        }
        
        if(Rotation != 0)
        {
            float angleTour = (360 / Rotation) * timeObject.GetComponent<time>().speedTime;

            transform.Rotate(new Vector3(0, -angleTour, 0)*Time.deltaTime);
        }

    }
}
