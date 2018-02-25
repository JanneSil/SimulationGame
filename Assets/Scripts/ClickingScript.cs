using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickingScript : MonoBehaviour {


    
    private Transform clickedObject;
    private bool objectClicked;
    public GameObject InfoMenu;
    public Text InfoText;

    //Doubleclick
    private bool oneClick;
    private bool doubleClick;
    private float timerForDoubleClick;
    private float delay = 0.25f;


    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        CheckDoubleClick();

        if (Input.GetButton("Fire1") && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            
            if (Physics.Raycast(ray, out hit, 1000))
            {

                if (hit.collider.tag == "Info")
                { 
                    objectClicked = true;
                    InfoText.text = "Bakery";

                }
                else if (hit.collider.tag == "Baker")
                {
                    objectClicked = true;
                    InfoText.text = "Baker";

                }
                else if (hit.collider.tag == "Farmer")
                {
                    objectClicked = true;
                    InfoText.text = "Farmer";
                }
                else if (hit.collider.tag == "Woodcutter")
                {
                    objectClicked = true;
                    InfoText.text = "Woodcutter";
                }

                else if (hit.collider.tag == "Farm")
                {
                    objectClicked = true;
                    InfoText.text = "Farm";
                }

                else if (hit.collider.tag == "Windmill")
                {
                    objectClicked = true;
                    InfoText.text = "Storage";

                }
                else if (hit.collider.tag == "WoodChopper")
                {
                    objectClicked = true;
                    InfoText.text = "Woodcutting";

                }

                else if (hit.collider.tag == "Houses")
                {
                    objectClicked = true;
                    InfoText.text = "Houses";

                }

                else 
                {
                    objectClicked = false;
                    InfoMenu.SetActive(false);

                }
            }
        }

        if (objectClicked)
        {
            ReadInfos(clickedObject);
        }

    }

    void ReadInfos(Transform target)
    {

        InfoMenu.SetActive(true);
        objectClicked = false;

    }


    void CheckDoubleClick()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!oneClick)
            {
                oneClick = true;
                timerForDoubleClick = Time.time;
            }
            else
            {
                oneClick = false;
                doubleClick = true;
            }
        }

        if (oneClick)
        {
            if ((Time.time - timerForDoubleClick) > delay)
            {
                oneClick = false;
                doubleClick = false;
            }
        }
    }
}
