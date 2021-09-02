using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSpinX : MonoBehaviour
{
    private float speedProp = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, speedProp * Time.deltaTime, Space.Self);
    }
}
