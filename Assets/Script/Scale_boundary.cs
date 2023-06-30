using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale_boundary : MonoBehaviour
{
    public Vector3 vc;
    int x,y,z;
    // Start is called before the first frame update
    void Start()
    {
        
        vc = new Vector3 (1,1,1);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x > 1)
        {
            transform.localScale = vc;
        }
    }
}
