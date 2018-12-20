using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler {

	public bool empty;
	public Texture slotTexture;
	public Texture itemTexture;
	public GameObject item;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// changing texture
		if (item) {
			itemTexture = item.GetComponent<Item>().itemTexture;
			this.GetComponent<RawImage>().texture = itemTexture;

			empty = false;

		} else {
			this.GetComponent<RawImage>().texture = slotTexture;

			empty = true;
		}
	}

	public void OnPointerDown (PointerEventData eventData) {
		if (item) {
			item.SetActive(true);
		}
	}

	public void OnPointerEnter (PointerEventData eventData) {
		
	}
	

}
