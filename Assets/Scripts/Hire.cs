using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hire : MonoBehaviour {

    public GameObject Farmer;
    public GameObject Woodcutter;
    public GameObject Baker;
    public GameObject SpawnPoint;

    public void HireFarmer()
    {
        Instantiate(Farmer, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        Debug.Log("HiredFarmer");
    }

    public void HireWoodcutter()
    {
        Instantiate(Woodcutter, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        Debug.Log("HiredWoodcutter");
    }

    public void HireBaker()
    {
        Instantiate(Baker, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        Debug.Log("HiredBaker");
    }


}
