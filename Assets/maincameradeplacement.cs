using UnityEngine;
using UnityEngine.UI;

public class maincameradeplacement : MonoBehaviour
{
    [SerializeField] float maxRayon=1000;
    [SerializeField] float speed =-1000000;
    [SerializeField] float speed2 = 100;


    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] Slider slider;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, min + (max - min) * slider.value,transform.position.z);

        if (Input.GetMouseButton(0) && new Vector2(transform.position.x,transform.position.z).magnitude<maxRayon)
        {

            Vector3 mal= new Vector3(Input.GetAxis("Mouse X") * Time.deltaTime * speed,
                                       0.0f, Input.GetAxis("Mouse Y") * Time.deltaTime * speed);
            if( new Vector2( (transform.position+mal).x,(transform.position + mal).z).magnitude<maxRayon )
            {
                transform.position+=mal;
            }
        }


    }
}
