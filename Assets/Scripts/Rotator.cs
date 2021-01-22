using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //multiplying by deltaTime so it rotates smoothly 
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
