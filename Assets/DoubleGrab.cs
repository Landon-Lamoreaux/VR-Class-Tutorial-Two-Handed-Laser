using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleGrab : MonoBehaviour
{
    // The user must choose the grab points to activate.
    [SerializeField]
    private GameObject grabPoint1;
    [SerializeField]
    private GameObject grabPoint2;

    // Monitors what hand has what object.
    private Tuple<GameObject, GameObject> first;
    private Tuple<GameObject, GameObject> second;

    // Callbacks.
    public delegate void DoubleHandEvent(GameObject inHand1, GameObject hand1, GameObject inHand2, GameObject hand2);
    public event DoubleHandEvent DoubleGrabObject;
    public event DoubleHandEvent DoubleReleaseObject;

    void OnGrab(GameObject o, GameObject controller)
    {
        Debug.Log("In on Grab Object");
    }
    void OnRelease(GameObject o, GameObject controller)
    {
        Debug.Log("In on Release Object");
    }

    // Start is called before the first frame update.
    void Start()
    {
        // This is slow, but will find the grab scripts on the controller anywhere in the scene.
        Grab[] childScript = GameObject.FindObjectsOfType<Grab>();
        
        // Monitor them both, but we do not care if it is right or left handed.
        for (int i = 0; i < childScript.Length; i++)
        {
            childScript[i].GrabObject += OnGrab;
            childScript[i].ReleaseObject += OnRelease;
        }
    }

    // Update is called once per frame.
    void Update()
    {
        
    }
}
