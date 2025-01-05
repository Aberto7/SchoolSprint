using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public new Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animation.SetBool("run", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animation.SetBool("run", false);
        }
    }
}
