using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftBox : MonoBehaviour
{
    public Animator Animator;
    public bool Opened = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!Opened)
            StartCoroutine(OpenBox());
    }

    private IEnumerator OpenBox()
    {
        Animator.Play("Shake");
        yield return new WaitForSeconds(3);
        Opened = true;
    }
}
