using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer m_renderer;
    Rigidbody rigidBody;

    [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        m_renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        m_renderer.enabled = false;
        rigidBody.useGravity = false;


    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            m_renderer.enabled = true;
            rigidBody.useGravity = true;
            Debug.Log("3 sec has passed");
        }
    }
}
