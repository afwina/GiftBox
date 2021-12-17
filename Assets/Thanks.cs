using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thanks : MonoBehaviour
{
    public bool Done;
    public TMPro.TextMeshProUGUI Text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Done)
        {
            Destroy(gameObject);
        }
    }
}
