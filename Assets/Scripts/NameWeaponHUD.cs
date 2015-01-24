using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NameWeaponHUD : MonoBehaviour, IPointerEnterHandler, ISelectHandler{

	Text text;
	public Button weapon1, weapon2, weapon3, weapon4;

	// Use this for initialization
	void Start () {

		weapon1 = GetComponent<Button> ();

	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		Debug.Log("Hovered");
	}
	
	public void OnSelect(BaseEventData eventData)
	{
		Debug.Log("Hovered");
	}
}
