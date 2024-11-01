
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float inputVer = Input.GetAxis("Vertical");


        float inputHor = Input.GetAxis("Horizantal");
        if (inputHor != 0)
        {
            //Imput true
            gameObject.transform.Rotate(0, inputHor, 0);
        }

        if (inputVer != 0)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}