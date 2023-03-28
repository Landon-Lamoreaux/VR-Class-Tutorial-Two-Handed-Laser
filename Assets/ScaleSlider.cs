using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSlider : MonoBehaviour
{
    [SerializeField]
    private ApparatusLaser laser;
    private GameObject gripHandA;
    private GameObject gripA;
    private GameObject gripHandB;
    private GameObject gripB;
    private GameObject bar;
    private float minExtent = 0;
    private float maxExtent = 0;
    [SerializeField]
    private float minLaserWidth = 0.01f;
    [SerializeField]
    private float maxLaserWidth = 0.1f;

    // Start is called before the first frame update.
    void Start()
    {
        // Register.
        DoubleGrab grab = GetComponentInChildren<DoubleGrab>();
        grab.DoubleGrabObject += OnGrab;
        grab.DoubleReleaseObject += OnRelease;

        // Find determine range of slider.
        bar = GameObject.Find("Bar");
        minExtent = -bar.transform.lossyScale.x / 2;
        maxExtent = bar.transform.lossyScale.x / 2;
    }
    void OnGrab(GameObject inHand1, GameObject hand1, GameObject inHand2, GameObject hand2)
    {
        gripHandA = hand1;
        gripA = inHand1;
        gripHandB = hand2;
        gripB = inHand2;
        Debug.Log("Slider active");
    }
    void OnRelease(GameObject inHand1, GameObject hand1, GameObject inHand2, GameObject hand2)
    {
        gripHandA = null;
        gripHandB = null;
        Debug.Log("Slider inactive");
    }

    private void Update()
    {
        if (gripHandA != null && gripHandB != null)
        {
            MoveHandle(gripB, gripHandB);
            MoveHandle(gripA, gripHandA);

            float distance = Vector3.Distance(gripA.transform.position, gripB.transform.position);
            float maxRange = maxExtent - minExtent;
            float percent = distance / maxRange;
            float amount = minLaserWidth + percent * (maxLaserWidth - minLaserWidth);
            laser.SetWidth(amount);
        }
    }
    private void MoveHandle(GameObject grip, GameObject hand)
    {
        // Converts the hand's world position to the bar's local space.
        Vector3 handInLocalSpace = bar.transform.InverseTransformPoint(hand.transform.position);
        
        // Only care about x direction, since bar was original alone the x axis.
        float x = handInLocalSpace.x;
        if (x < minExtent)
        {
            x = minExtent;
        }
        if (x > maxExtent)
        {
            x = maxExtent;
        }
        grip.transform.localPosition = new Vector3(x, 0, 0);
    }
}
