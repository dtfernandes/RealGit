using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float lel;
    public bool a;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (lel < 5)
        {
            transform.Rotate(new Vector3(20, 20, 20));
        }

        if (!a)
        {
            lel += 0.5f;
            if (lel > 12)
            {
                a = true;
            }
        }
        else
        {
            lel -= 0.5f;
            if (lel < 0.5f)
            {
                a = false;
            }
        }

        transform.localScale = new Vector3(lel,transform.localScale.y,transform.localScale.z);

        transform.Rotate(new Vector3(1, 1, 1));
    }
}
