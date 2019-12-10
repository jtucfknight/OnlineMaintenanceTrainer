using UnityEngine;
using System.Collections;

public class objectRemove : MonoBehaviour 
{
	/*Create variables to show up in the inspector.*/
	public Animator passengerFrontWheel;
	public Animator passengerRearWheel;
	public Animator driverFrontWheel;
	public Animator driverRearWheel;
	public Animator frontLifter;
	public Animator driverLifter;
	public Animator passengerLifter;
    public Animator missileLauncher;
    public Animator hydraulicLifts;

	void Start ()
	{
	}
   
    public void psgrFront_Off ()
    {
        passengerFrontWheel.Play ("pFrontTire_Off");

    }
    public void psgrFront_On ()
    {
        passengerFrontWheel.Play ("pFrontTire_On");
    }

	public void psgrRear_Off ()
	{
		passengerRearWheel.Play ("pRearTire_Off");
	}
	public void psgrRear_On ()
	{
		passengerRearWheel.Play ("pRearTire_On");
	}

	public void frtLifter_Off ()
	{
		frontLifter.Play ("frontLifter_Off");
	}
	public void frtLifter_On ()
	{
		frontLifter.Play ("frontLifter_On");
	}

	public void frtDriver_Off ()
	{
		driverFrontWheel.Play ("driverFrontTire_Off");
	}
	public void frtDriver_On ()
	{
		driverFrontWheel.Play ("driverFrontTire_On");
	}

	public void driverRear_Off ()
	{
		driverRearWheel.Play ("driverRearTire_Off");
	}
	public void driverRear_On ()
	{
		driverRearWheel.Play ("driverRearTire_On");
	}

	public void driverLifter_Off ()
	{
		driverLifter.Play ("driverLifter_Off");
	}
	public void driverLifter_On ()
	{
		driverLifter.Play ("driverLifter_On");
	}

	public void passengerLifter_Off ()
	{
		passengerLifter.Play ("passengerLifter_Off");
	}
	public void passengerLifter_On ()
	{
		passengerLifter.Play ("passengerLifter_On");
	}

	void update()
	{

	}
}
