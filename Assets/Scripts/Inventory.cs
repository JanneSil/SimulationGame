using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public int flourLevel = 5;
	public int breadLevel = 0;
    public int wheatLevel = 0;
    public int woodLevel = 0;
    public int drawOffset = 0;
    public string name = "";

    public bool inventoryDraw = false;
	
	void OnGUI()
	{
        if (inventoryDraw)
        {
            GUI.Box(new Rect(0, 0 + drawOffset, 100, 100), "" + name);
            GUI.Label(new Rect(10, 20 + drawOffset, 100, 20), "Flour: " + flourLevel);
            //GUI.Label(new Rect(10, 35 + drawOffset, 100, 20), "Bread: " + breadLevel);
            //GUI.Label(new Rect(10, 50 + drawOffset, 100, 20), "Wheat: " + wheatLevel);
            GUI.Label(new Rect(10, 35 + drawOffset, 100, 20), "Wood: " + woodLevel);
        }
    }
}
