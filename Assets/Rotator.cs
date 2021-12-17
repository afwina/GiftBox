using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float XSpeed;
    public float YSpeed;
    public float ZSpeed;
    public bool On;
    
    private void Update()
    {
        transform.Rotate(new Vector3(XSpeed, YSpeed, ZSpeed));
    }
}
