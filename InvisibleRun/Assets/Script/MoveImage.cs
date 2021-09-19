using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveImage : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0005f, 0, 0);
        if (transform.position.x > 18.47f)
        {
            transform.position = new Vector3(-18.47f, 1,10);
        }
    }
}
