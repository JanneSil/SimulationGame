﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutWood : GoapAction {

    bool completed = false;
    float startTime = 0;
    public float workDuration = 2.0f;

    public CutWood()
    {
        addPrecondition("hasWoodDelivery", false);
        addEffect("doJob", true);
        name = "Woodcut";
    }

    public override bool checkProceduralPrecondition(GameObject agent)
    {
        return true;
    }

    public override bool isDone()
    {
        return completed;
    }

    public override bool requiresInRange()
    {
        return true;
    }

    public override void reset()
    {
        completed = false;
        startTime = 0f;
    }

    public override bool perform(GameObject agent)
    {
        if (startTime == 0)
        {
            Debug.Log("Starting: " + name);
            startTime = Time.time;
        }
        if (Time.time - startTime > workDuration)
        {
            Debug.Log("Finished: " + name);
            GetComponent<Inventory>().woodLevel++;
            completed = true;
        }

        return true;
    }
}
