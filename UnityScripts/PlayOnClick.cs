using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayOnClick : MonoBehaviour 
{
    public Animator passengerFrontWheel;
    public Animator passengerRearWheel;
    public Animator driverFrontWheel;
    public Animator driverRearWheel;
    public Animator frontLifter;
    public Animator passengerLifter;
    public Animator driverLifter;
    public Animator missileLauncher;
    public Animator hydraulicLift;
    private string theObjName;
    private List<int> m_List = new List<int>();
    public List<GameObject> m_Selected = new List<GameObject>();

    public void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
        RaycastHit hit;

        if( Physics.Raycast( ray, out hit, 100 ) )
        {
            Debug.Log( hit.transform.gameObject.name );
            theObjName = hit.transform.gameObject.name;

            if (theObjName == "passengerFrontRim") 
            {
                Debug.Log ("passengerFrontRim has been selected.");
                if (Input.GetMouseButtonDown(0)) 
                {
                    if (!m_List.Contains(0))
                    {
                        passengerFrontWheel.Play ("pFrontTire_Off");
                        m_List.Add(0);
                        m_Selected.Add(hit.transform.gameObject);
                    }
                    else
                    {
                        passengerFrontWheel.Play ("pFrontTire_On");
                        m_List.Remove(0);
                        m_Selected.Remove(hit.transform.gameObject);
                    }
                }
            }
            else if (theObjName == "passengerRearRim") 
            {
                Debug.Log ("passengerRearRim has been selected.");
                if (Input.GetMouseButtonDown(0)) 
                {
                    if (!m_List.Contains(1))
                    {
                        passengerRearWheel.Play ("pRearTire_Off");
                        m_List.Add(1);
                        m_Selected.Add(hit.transform.gameObject);
                    } 
                    else
                    {
                        passengerRearWheel.Play ("pRearTire_On");
                        m_List.Remove(1);
                        m_Selected.Remove(hit.transform.gameObject);
                    }
                }
            }
            else if (theObjName == "driverFrontRim") 
            {
                Debug.Log ("driverFrontRim has been selected.");
                if (Input.GetMouseButtonDown(0)) 
                {
                    if (!m_List.Contains(2))
                    {
                        driverFrontWheel.Play ("driverFrontTire_Off");
                        m_List.Add(2);
                        m_Selected.Add(hit.transform.gameObject);
                    } 
                    else
                    {
                        driverFrontWheel.Play ("driverFrontTire_On");
                        m_List.Remove(2);
                        m_Selected.Remove(hit.transform.gameObject);
                    }
                }
            }
            else if (theObjName == "driverRearRim") 
            {
                Debug.Log ("driverRearRim has been selected.");
                if (Input.GetMouseButtonDown(0)) 
                {
                    if (!m_List.Contains(3))
                    {
                        driverRearWheel.Play ("driverRearTire_Off");
                        m_List.Add(3);
                        m_Selected.Add(hit.transform.gameObject);
                    } 
                    else
                    {
                        driverRearWheel.Play ("driverRearTire_On");
                        m_List.Remove(3);
                        m_Selected.Remove(hit.transform.gameObject);
                    }
                }
            }
            else if (theObjName == "front_lifter") 
            {
                Debug.Log ("front_lifter has been selected.");
                if (Input.GetMouseButtonDown(0)) 
                {
                    if (!m_List.Contains(4))
                    {
                        frontLifter.Play ("frontLifter_Off");
                        m_List.Add(4);
                        m_Selected.Add(hit.transform.gameObject);
                    } 
                    else
                    {
                        frontLifter.Play ("frontLifter_On");
                        m_List.Remove(4);
                        m_Selected.Remove(hit.transform.gameObject);
                    }
                }
            }
            else if (theObjName == "missile_launcher" || theObjName == "hydraulic_lifts") 
            {
                Debug.Log ("missile_launcher or hydraulic_lifts has been selected.");
                if (Input.GetMouseButtonDown(0)) 
                {
                    if (!m_List.Contains(5))
                    {
                        missileLauncher.Play ("missileLauncher_Off");
                        hydraulicLift.Play ("hydrualicLift_Off");
                        m_List.Add(5);
                    } 
                    else
                    {
                        missileLauncher.Play ("missileLauncher_On");
                        hydraulicLift.Play ("hydrualicLift_On");
                        m_List.Remove(5);
                    }
                }
            }
            else if (theObjName == "passengerLifter") 
            {
                Debug.Log ("passengerLifter has been selected.");
                if (Input.GetMouseButtonDown(0)) 
                {
                    if (!m_List.Contains(6))
                    {
                        passengerLifter.Play ("passengerLifter_Off");
                        m_List.Add(6);
                    } 
                    else
                    {
                        passengerLifter.Play ("passengerLifter_On");
                        m_List.Remove(6);
                    }
                }
            }
            else if (theObjName == "driverLifter") 
            {
                Debug.Log ("driverLifter has been selected.");
                if (Input.GetMouseButtonDown(0)) 
                {
                    if (!m_List.Contains(7))
                    {
                        driverLifter.Play ("driverLifter_Off");
                        m_List.Add(7);
                    } 
                    else
                    {
                        driverLifter.Play ("driverLifter_On");
                        m_List.Remove(7);
                    }
                }
            }
            else
            {
                Debug.Log ("NULL");
            }
        }
    }
}