using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grab : MonoBehaviour
{
    private PlayerInput filter;
    private InputAction grab;
    private InputAction release;
    private List<GameObject> inRange = new List<GameObject>();
    private GameObject inHand = null;
    public delegate void ObjectEvent(GameObject obj, GameObject controller);
    public event ObjectEvent GrabObject;
    public event ObjectEvent ReleaseObject;

    // Start is called before the first frame update.
    void Start()
    {
        filter = GameObject.FindObjectOfType<PlayerInput>();

        // Have to separate controller events to hand if BOTH need to be fully monitored.
        if (name.Contains("Left"))
        {
            grab = filter.actions["GrabLeft"];
            release = filter.actions["ReleaseLeft"];
        }
        else
        {
            grab = filter.actions["GrabRight"];
            release = filter.actions["ReleaseRight"];
        }
    }
    // Register and unregiser within range.
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Grabbable")
        {
            grab.started += OnGrab;
            release.performed += OnRelease;
            inRange.Add(other.gameObject);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Grabbable")
        {
            inRange.Remove(other.gameObject);
            
            // Last one, deregister.
            if (inRange.Count == 0)
            {
                grab.started -= OnGrab;
                release.performed -= OnRelease;
            }
        }
    }
    // Grab action.
    public void OnGrab(InputAction.CallbackContext context)
    {
        // Sanity check, do not grab if hands are full.
        if (inHand == null)
        {
            GameObject closest = inRange[0];
            for (int i = 1; i < inRange.Count; i++)
            {
                if ((this.transform.position - closest.transform.position).magnitude >
                (this.transform.position - inRange[i].transform.position).magnitude)
                {
                    closest = inRange[i];
                }
            }
            inHand = closest;
            if (GrabObject != null)
            {
                GrabObject(inHand, this.gameObject);
            }
        }
    }
    // Release action.
    public void OnRelease(InputAction.CallbackContext context)
    {
        if (inHand != null)
        {
            if (ReleaseObject != null)
            {
                ReleaseObject(inHand, this.gameObject);
            }
            inHand = null;
        }
    }
}