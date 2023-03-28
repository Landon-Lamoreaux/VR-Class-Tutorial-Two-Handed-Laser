using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class FullManipulation : MonoBehaviour
{
    [SerializeField]
    private float minScale = 0.5f;
    [SerializeField]
    private float maxScale = 2;

    private GameObject gripHandA;
    private GameObject gripHandB;
    private float initScale; // Now watch for scale instead of coordinate system.
    void Start()
    {
        // Register.
        DoubleGrab grab = GetComponentInChildren<DoubleGrab>();
        grab.DoubleGrabObject += OnGrab;
        grab.DoubleReleaseObject += OnRelease;
        initScale = transform.localScale.x; // Now watch for scale instead of coordinate system.
    }
    private void Update()
    {
        if (gripHandA != null && gripHandB != null)
        {
            // Point halfway between.
            Vector3 p = (gripHandA.transform.position + gripHandB.transform.position) / 2;
            
            // Direction, and distance between hands.
            Vector3 v = gripHandA.transform.position - gripHandB.transform.position;
            
            // Percentage change from base, with limits.
            float newScale = (v.magnitude / initScale);
            if (newScale < minScale)
            {
                newScale = minScale;
            }
            if (newScale > maxScale)
            {
                newScale = maxScale;
            }
            newScale *= initScale;

            v.Normalize();
            Quaternion q = Quaternion.LookRotation(v);

            float theta = (gripHandA.transform.rotation.eulerAngles.x + gripHandB.transform.rotation.eulerAngles.x) / 2;
            
            // Handle hand order reverse.
            Vector3 localHandA = transform.parent.InverseTransformPoint(gripHandA.transform.position);
            Vector3 localHandB = transform.parent.InverseTransformPoint(gripHandB.transform.position);
            if (localHandA.x < localHandB.x)
                theta = -theta;
            Quaternion roll = Quaternion.AngleAxis(theta, v);

            transform.transform.position = p; ;
            transform.localScale = new Vector3(newScale, newScale, newScale);
            transform.rotation = roll * q;
        }
    }
    void OnGrab(GameObject inHand1, GameObject hand1, GameObject inHand2, GameObject hand2)
    {
        gripHandA = hand1;
        gripHandB = hand2;

        // Take control of the object in code, and turn off physics.
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().useGravity = false;
    }
    void OnRelease(GameObject inHand1, GameObject hand1, GameObject inHand2, GameObject hand2)
    {
        gripHandA = null;
        gripHandB = null;

        // Turn physics on.
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().useGravity = true;

        // Give an average of physics of both hands.
        List<InputDevice> inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(
        InputDeviceCharacteristics.HeldInHand, inputDevices);
        Vector3 state;
        Vector3 ave = Vector3.zero;
        Vector3 aveA = Vector3.zero;
        foreach (InputDevice inputDevice in inputDevices)
        {
            inputDevice.TryGetFeatureValue(CommonUsages.deviceVelocity, out state);
            ave += state;
            inputDevice.TryGetFeatureValue(CommonUsages.deviceAngularVelocity, out state);
            aveA += state;
        }
        ave /= inputDevices.Count; ;
        aveA /= inputDevices.Count;

        // Transfer force...if this is not supported, ave and aveA will be 0, and the object will just drop.
        Rigidbody body = GetComponent<Rigidbody>();
        body.velocity = ave;
        body.angularVelocity = aveA;

        // Estimate force by velocity over time.
        float force = ave.magnitude / Time.fixedDeltaTime;
        Vector3 applyForce = force * ave.normalized;
        body.AddForce(applyForce, ForceMode.Force);
    }
}
