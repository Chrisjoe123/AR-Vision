using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignPositionUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject StartPos, Bg;


    public void ResetPos()
    {
        Bg.transform.position = StartPos.transform.position;
    }
}
