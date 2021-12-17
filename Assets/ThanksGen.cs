using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanksGen : MonoBehaviour
{
    public GiftBox Gift;
    public string[] Messages;
    public Thanks Prefab;
    public Transform Canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Gift.Opened)
        {
            var thanks = Instantiate(Prefab, Canvas);
            thanks.transform.position = Input.mousePosition;//new Vector3(Random.Range(0,Screen.width), Random.Range(0,Screen.height));
            thanks.Text.text = Messages[Random.Range(0, Messages.Length)];
        }
    }
}
