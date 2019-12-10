using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SwapTire : MonoBehaviour 
{
    public GameObject pf_defaultTire;
    public GameObject pr_defaultTire;
    public GameObject df_defaultTire;
    public GameObject dr_defaultTire;
    public GameObject frontLifter;
    public GameObject dFrontTire;
    public GameObject dRearTire;
    public GameObject pFrontTire;
    public GameObject pRearTire;
    public  Dropdown tireDropdown;
    private List<int> tireList = new List<int>();
    private PlayOnClick tires;

    void Start()
    {
        df_defaultTire.GetComponent<Renderer>().enabled = true;
        dr_defaultTire.GetComponent<Renderer>().enabled = true;
        pf_defaultTire.GetComponent<Renderer>().enabled = true;
        pr_defaultTire.GetComponent<Renderer>().enabled = true;
        frontLifter.GetComponent<Renderer>().enabled = true;

        dFrontTire.GetComponent<Renderer>().enabled = false;
        dRearTire.GetComponent<Renderer>().enabled = false;
        pFrontTire.GetComponent<Renderer>().enabled = false;
        pRearTire.GetComponent<Renderer>().enabled = false;

        tires = GameObject.Find("animOnClickScript").GetComponent<PlayOnClick>();
    }
    public void setTire()
    {
        // set all tires to default
        if (tireDropdown.value == 0)
        {
            foreach (GameObject o in tires.m_Selected)
            {
                if (o.name == "driverFrontRim")
                {
                    df_defaultTire.GetComponent<Renderer>().enabled = true;
                    dFrontTire.GetComponent<Renderer>().enabled = false; 
                }
                else if (o.name == "driverRearRim")
                {
                    dr_defaultTire.GetComponent<Renderer>().enabled = true;
                    dRearTire.GetComponent<Renderer>().enabled = false;
                }
                else if (o.name == "passengerFrontRim")
                {
                    pf_defaultTire.GetComponent<Renderer>().enabled = true;
                    pFrontTire.GetComponent<Renderer>().enabled = false;
                }
                else if (o.name == "passengerRearRim")
                {
                    pr_defaultTire.GetComponent<Renderer>().enabled = true;
                    pRearTire.GetComponent<Renderer>().enabled = false;
                }
                else if (o.name == "front_lifter")
                {
                    Debug.Log("Front lifter is true!!");
                    frontLifter.GetComponent<Renderer>().enabled = true;
                   
                }
            }
        }
        // on change click
        else if (tireDropdown.value == 1)
        {
            foreach (GameObject o in tires.m_Selected)
            {
                if (o.name == "driverFrontRim")
                {
                    df_defaultTire.GetComponent<Renderer>().enabled = false;
                    dFrontTire.GetComponent<Renderer>().enabled = true;
                }
                else if (o.name == "driverRearRim")
                {
                    dr_defaultTire.GetComponent<Renderer>().enabled = false;
                    dRearTire.GetComponent<Renderer>().enabled = true; 
                }
                else if (o.name == "passengerFrontRim")
                {
                    pf_defaultTire.GetComponent<Renderer>().enabled = false;
                    pFrontTire.GetComponent<Renderer>().enabled = true;
                }
                else if (o.name == "passengerRearRim")
                {
                    pr_defaultTire.GetComponent<Renderer>().enabled = false;
                    pRearTire.GetComponent<Renderer>().enabled = true;
                }
                else if (o.name == "front_lifter")
                {
                    Debug.Log("Front lifter is false!!");
                    frontLifter.GetComponent<Renderer>().enabled = false;

                }
            }
        }
    }
}