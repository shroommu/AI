using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Made By Anthony Romrell
public class NoNew : MonoBehaviour
{

	public string MyString;
	public int MyInt;
	
	public Vector3 vect;
	
	private void OnMouseDown()
	{
		vect.Set(0,0,0);
		
		PointerEventData pointerEvent = new PointerEventData(EventSystem.current){position = Input.mousePosition};
		List<RaycastResult> hits = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEvent, hits);
	}
}
