using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameUnit : MonoBehaviour
{
	private bool followMouse = true;
	private bool startFollowThisFrame = false;
	private Vector2 offset = Vector2.zero;

	private void Update()
	{
		if (followMouse)
		{
			transform.position = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
			if (Input.GetButtonDown("Fire1") && !startFollowThisFrame)
			{
				followMouse = false;
			}
		}
		startFollowThisFrame = false;
	}

	private void OnMouseDown()
	{
		if (followMouse) return;
		if (!startFollowThisFrame) startFollowThisFrame = true;
		followMouse = true;
		offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
}
