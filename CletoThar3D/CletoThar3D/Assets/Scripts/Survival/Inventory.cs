using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	
	public bool inventoryEnabled;
	public GameObject inventory;
	public GameObject itemDatabase;
	private Transform[] slot;
	public GameObject slotHolder;
	private bool pickedUpitem;



	void Start () {
		GetAllSlots();
	}
	

	void Update () {
		// enabling inventory
		if (Input.GetKeyDown(KeyCode.I)) {
			inventoryEnabled = !inventoryEnabled;
		}

		if (inventoryEnabled) {
			inventory.SetActive(true);
		} else {
			inventory.SetActive(false);
		}

	}

	public void OnTriggerEnter(Collider other) {
		if (other.tag == "item") {
			
				AddItem(other.gameObject);
			
		}
	}

	public void AddItem(GameObject item) {
		if (item.GetComponent<ItemPickUo>().craftMaterial == false) {

				GameObject rootItem;
				rootItem = item.GetComponent<ItemPickUo>().rootItem;
		

				for (int i = 0; i < 25; i++) {
					if (slot[i].GetComponent<Slots>().empty == true && item.gameObject.GetComponent<ItemPickUo>().pickedUp == false) {
						
						
								slot[i].GetComponent<Slots>().item = rootItem;
								item.GetComponent<ItemPickUo>().pickedUp = true;
								Destroy(item);
							
					} 
				}
		}	else {

		for (int i = 0; i < 25; i++) {
			if (slot[i].GetComponent<Slots>().empty == true && item.gameObject.GetComponent<ItemPickUo>().pickedUp == false) {
				
				
						slot[i].GetComponent<Slots>().item = item;
						item.GetComponent<ItemPickUo>().pickedUp = true;
						item.transform.parent = itemDatabase.transform;
						//item.SetActive(false);
					
			} 
		}
		}
	
	}

	public void GetAllSlots() {
		slot = new Transform[25];
		for (int i = 0; i < 25; i++){
			slot[i] = slotHolder.transform.GetChild(i);

		}

	}
}
