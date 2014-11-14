using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	public float setupSpinSpeed = 85.0f;

	public Color red = Color.red;
	public Color blue = Color.blue;
	public Color green = Color.green;
	public Color yellow = Color.yellow;
	public Color white = Color.white;

	void Start () 
	{

	}

	void PlayerUpdate () 
	{
	
	}

	public void PickedColor (Color playerColor)
	{
		renderer.material.color = playerColor;
	}
}
