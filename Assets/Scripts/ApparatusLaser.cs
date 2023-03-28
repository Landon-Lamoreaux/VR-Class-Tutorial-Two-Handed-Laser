﻿using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ApparatusLaser : MonoBehaviour
{
    private Bounds bounds;
    private LineRenderer line;
    [SerializeField]
    private float startingWidth = 0.05f;
    [SerializeField]
    private float maxDistance = 20;
    [SerializeField]
    private int maxBounce = 10;
    void Start()
    {
        // Make a line renderer.
        line = new GameObject("line").AddComponent<LineRenderer>();

        // Give it a base material so the color can be changed.
        line.material = new Material(Shader.Find("Sprites/Default"));
        SetWidth(startingWidth);
    }
    public void SetWidth(float width)
    {
        line.startWidth = width;
        line.endWidth = width;
    }


    public void SetColor(Color c)
    {

    }
    void Update()
    {
        bounds = GetComponent<Collider>().bounds;
        MakeReflection();
    }
    private void MakeReflection()
    {
        Vector3 start = new Vector3(bounds.center.x, bounds.max.y, bounds.center.z);
        Vector3 direction = transform.up;

        List<Vector3> points = new List<Vector3>();
        points.Add(start);
        
        // Repeatly bounce laser until absorbed, nothing hit, or max bonces met.
        int count = 1;
        bool done = false;
        while (!done)
        {
            // Shoot out a ray that aligns to the current points.
            RaycastHit hit;
            if (Physics.Raycast(start, direction, out hit))
            {
                // Hit a mirror, add point and bounce.
                if (hit.collider.name.Contains("Mirror"))
                {
                    points.Add(hit.point);

                    // Calculate the new direction r = d−2(d⋅n)n.
                    start = hit.point;
                    direction = direction - 2 * Vector3.Dot(direction, hit.normal) * hit.normal;
                    direction.Normalize();
                }
                else
                {
                    //laser absorbed
                    points.Add(hit.point);
                    done = true;
                }
            }
            else
            {
                // Nothing hit, stop.
                points.Add(start + direction * maxDistance);
                done = true;
            }

            // Stop infinite reflection.
            count++;
            if (count > maxBounce)
                done = true;
        }
        line.positionCount = count;
        line.SetPositions(points.ToArray());
    }
}
