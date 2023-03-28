using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class ApparatusKeyboard : MonoBehaviour
{
    private ApparatusLaser laser;
    private float raiseSpeed = 0.01f;
    [SerializeField]
    private float minRaise = 1;
    [SerializeField]
    private float maxRaise = 1.3f;


    void Start()
    {
        laser = GetComponentInChildren<ApparatusLaser>();

        PlayerInput input = GameObject.FindObjectOfType<PlayerInput>();
        input.actions["Move"].performed += OnMove;
        input.actions["Scale"].performed += OnScale;
        input.actions["ColorChange"].performed += OnColorChange;

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMove(InputAction.CallbackContext value)
    {
        Vector2 amount = value.ReadValue<Vector2>();

        float y = transform.position.y + amount.y * raiseSpeed;
        if (y < minRaise)
            y = minRaise;
        if (y > maxRaise)
            y = maxRaise;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        transform.Rotate(transform.up, amount.x);

    }

    public float minWidth = 0.01f;
    public float maxWidth = 0.1f;
    public float widthChangeSpeed = 0.01f;
    private float curWidth = 0.05f;
    void OnScale(InputAction.CallbackContext value)
    {
        try
        {
            float amount = value.ReadValue<float>();
            curWidth = curWidth + amount * widthChangeSpeed;

            if (curWidth < minWidth)
                curWidth = minWidth;
            if (curWidth > maxWidth)
                curWidth = maxWidth;
            laser.SetWidth(curWidth);
        }
        catch (Exception e)
        {
            //bad cast, skip it
        }
    }

    void OnColorChange(InputAction.CallbackContext value)
    {
        //only check on press

        //this is a hack. I scaled the input, so that the keys give me different values.
        float v = value.ReadValue<float>();
        int which = (int)v;

        switch (which)
        {
            case 1:
                laser.SetColor(Color.blue);
                break;
            case 2:
                laser.SetColor(Color.red);
                break;
            case 3:
                laser.SetColor(Color.green);
                break;
            case 4:
                laser.SetColor(Color.white);
                break;
        }

    }

}
