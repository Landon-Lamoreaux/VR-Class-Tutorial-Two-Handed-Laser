using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparatusVR : MonoBehaviour
{
    [SerializeField]
    private float minRaise = 0;
    [SerializeField]
    private float maxRaise = 0.3f;
    private GameObject gripHandA;
    private GameObject gripHandB;
    private GameObject handle;

    private Vector3 startPos;
    void Start()
    {
        // Register.
        DoubleGrab grab = GetComponentInChildren<DoubleGrab>();
        grab.DoubleGrabObject += OnGrab;
        grab.DoubleReleaseObject += OnRelease;

        // Movement will be relative to the handle.
        handle = transform.Find("Handle").gameObject;
        startPos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
    }
    private void Update()
    {
        if (gripHandA != null && gripHandB != null)
        {
            // Converts the hand's world position to the APPARATUS's (not bar's) local space.
            Vector3 localHandA = handle.transform.parent.InverseTransformPoint(gripHandA.transform.position);
            Vector3 localHandB = handle.transform.parent.InverseTransformPoint(gripHandB.transform.position);
            Vector3 average = (localHandA + localHandB) / 2;
            
            // Bounds.
            float y = transform.localPosition.y + average.y;
            if (y < startPos.y + minRaise)
            {
                y = startPos.y + minRaise;
            }
            if (y > startPos.y + maxRaise)
            {
                y = startPos.y + maxRaise;
            }
            transform.localPosition = new Vector3(startPos.x, y, startPos.z);

            // Basic rotation.
            // Converts the hand's world position to the apparatus’s local space.
            if (transform.parent != null)
            {
                localHandA = transform.parent.InverseTransformPoint(gripHandA.transform.position);
                localHandB = transform.parent.InverseTransformPoint(gripHandB.transform.position);
            }
            else
            {
                localHandA = (gripHandA.transform.position);
                localHandB = (gripHandB.transform.position);
            }
            Vector3 direction = localHandA - localHandB;

            // Flip direction if gripping in reverse.
            if (localHandA.x < localHandB.x)
            {
                direction = localHandB - localHandA;
            }
            float theta = Mathf.Atan2(direction.z, direction.x);
            transform.localRotation = Quaternion.Euler(new Vector3(0, -Mathf.Rad2Deg * theta, 0));
        }
    }
    // Update is called once per frame.
    void OnGrab(GameObject inHand1, GameObject hand1, GameObject inHand2, GameObject hand2)
    {
        gripHandA = hand1;
        gripHandB = hand2;
    }
    void OnRelease(GameObject inHand1, GameObject hand1, GameObject inHand2, GameObject hand2)
    {
        gripHandA = null;
        gripHandB = null;
    }
}
