using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stat : MonoBehaviour
{
    private Image content;
    public float maxValue { get; set; }
    public float PropCurrentValue
    {
        get { return currentValue; }
        set {
            if (value > maxValue)
                { currentValue = maxValue; } 
            else if (value < 0)
                { currentValue = 0; }
            else
            {
                currentValue = value;
            }
        }
    }

    private float currentValue;
    private float currentFill;
    // Start is called before the first frame update
    void Start()
    {
        content = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
