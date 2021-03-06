﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EventHandlerWeapon : MonoBehaviour, IPointerEnterHandler, ISelectHandler {
    public static string selectedWeapon;

	//Text text = "";
	Button weapon;
	public Image weaponCard;
	public Image weaponCardSlot;
	public Text weaponTitle;
	public Text weaponTitleSlot;
	public Text weaponText;
	public Text weaponTextSlot;
	// Use this for initialization
	void Start () {	
		weapon = GetComponent<Button> ();		
	}
	
	public void OnPointerEnter(PointerEventData eventData) {
		weaponTitleSlot.text = weaponTitle.text;
		weaponTextSlot.text = weaponText.text;
		weaponCardSlot.sprite = weaponCard.sprite;
	}
	
	public void OnSelect(BaseEventData eventData) {
		//weaponCardSlot.guiTexture.texture = weaponCard.guiTexture.texture;
		//weaponTitleSlot.guiText.text = weaponTitle.text;
		//weaponTextSlot.guiText.text = weaponText.text;
        
        selectedWeapon = eventData.selectedObject.name;
        Application.LoadLevel("game");
	}
}
