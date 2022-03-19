using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{



	public EquipmentSlot equipSlot; // Slot to store equipment in

	public int armorModifier;       // Increase/decrease in armor
	public int damageModifier;      // Increase/decrease in damage
	public SkinnedMeshRenderer mesh;
	public EquipmentManager.MeshBlendShape[] coveredMeshRegions;


	public override void Use()
	{
		base.Use();
		EquipmentManager.instance.Equip(this);  // Equip it
		RemoveFromInventory();                  // Remove it from inventory
	}

}

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield, Feet }