using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer varrenderer;
    Rigidbody varrigidbody;

    [SerializeField] float timeToWait = 2f;

    void Start()
    {
        varrenderer = GetComponent<MeshRenderer>();
        varrigidbody = GetComponent<Rigidbody>();

        varrenderer.enabled = false;
        varrigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            varrenderer.enabled = true;
            varrigidbody.useGravity = true;
        }
    }
}
