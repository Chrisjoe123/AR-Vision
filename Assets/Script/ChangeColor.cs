using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Color changedColor;
    public Button button1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeButtonColor()
    {
        ColorBlock cb = button1.colors;
        cb.normalColor = changedColor;
        cb.highlightedColor = changedColor;
        cb.pressedColor = changedColor;
        button1.colors = cb;
    }
}
