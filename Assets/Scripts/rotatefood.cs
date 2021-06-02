using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatefood : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
}
