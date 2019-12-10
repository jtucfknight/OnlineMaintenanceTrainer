using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

	public Color mouseOverColor;
    private Color defColor;

    public void Start()
    {
        defColor = GetComponent<Renderer> ().material.GetColor ("_Color");
    }
	void OnMouseEnter()
	{
		GetComponent<Renderer> ().material.SetColor ("_Color", mouseOverColor);
	}
	void OnMouseExit()
	{
        GetComponent<Renderer> ().material.SetColor ("_Color", defColor);
	}
}
