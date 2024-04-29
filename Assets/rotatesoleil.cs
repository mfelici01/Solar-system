using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatesoleil : MonoBehaviour
{
    public float vitesse = 0.1f;
    public Toggle animate;
    public Slider speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (animate.isOn)
        {
            transform.Rotate(Vector3.up, vitesse);
        }

        if (speed != null && animate.isOn)
        {
            transform.Rotate(Vector3.up, speed.value);
        }
    }
}
