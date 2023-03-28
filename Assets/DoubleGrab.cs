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
        // Not a monitored object.
        if (!(o == grabPoint1 || o == grabPoint2))
            return;
        // No item selected.
        if (first == null)
        {
            first = new Tuple<GameObject, GameObject>(o, controller);
        }
        else if ((first != null && grabPoint1 == grabPoint2) || o != first.Item1)
        {
            second = new Tuple<GameObject, GameObject>(o, controller);
            // Both hands have something, trigger!
            if (DoubleGrabObject != null)
            {
                DoubleGrabObject(first.Item1, first.Item2, second.Item1, second.Item2);
            }
        }
    }
    void OnRelease(GameObject o, GameObject controller)
    {
        // Sanity check.
        if (first == null)
        {
            return;
        }
        // Last release.
        else if (o == first.Item1 && second == null)
        {
            first = null;
        }
        // Second grab is still active, move it to first.
        else if (o == first.Item1 && second != null)
        {
            first = second;
            second = null;
            // Went from both hands having something, to one, trigger!
            if (DoubleReleaseObject != null)
            {
                DoubleReleaseObject(null, null, first.Item1, first.Item2);
            }
        }
        // First grab is still active, remove second.
        else
        {
            second = null;
            //went from both hands having something, to one, trigger!
            if (DoubleReleaseObject != null)
            {
                DoubleReleaseObject(first.Item1, first.Item2, null, null);
            }
        }
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
