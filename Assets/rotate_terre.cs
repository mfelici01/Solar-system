using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float vitesse = 0.1f;
    public float vitesseRote = 0.1f;
    public Transform centreRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, vitesse);
        transform.RotateAround(centreRotation.position, Vector3.up, vitesseRote);

    }
}
