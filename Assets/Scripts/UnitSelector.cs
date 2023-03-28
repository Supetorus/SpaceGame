using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitSelector : MonoBehaviour, IPointerClickHandler
{
	[SerializeField]
	private GameUnit prefab;
	public void OnPointerClick(PointerEventData eventData)
	{
		Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Instantiate(prefab, mousePosition, Quaternion.identity);
	}
}
