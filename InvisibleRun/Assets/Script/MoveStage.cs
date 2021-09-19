using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStage : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);
        if (transform.position.x < -21.95f)
        {
            transform.position = new Vector3(21.95f, 0,-10);
        }
    }
}
