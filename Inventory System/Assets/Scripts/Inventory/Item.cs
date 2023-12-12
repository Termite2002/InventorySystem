using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Inventory
{
    public abstract class Item : ScriptableObject
    {
        [Header("Main Item Components")]
        public string itemName;
        [Multiline] public string description;
        public int id;
        public ItemType type;
        public SlotType slotType;
        public Frequency frequency;
        public Vector2Int slotSize;
        public Sprite image;
        public Color backgroundColor;
        public GameObject prefab;

        public enum ItemType
        {
            Weapon,
            Food,
            Cloth,
            Money,
            Ammo,
            Magazine,
            Special
        }
        public enum SlotType
        {
            General,
            Headset,
            Headwear,
            FaceCover,
            TacticalRig,
            BodyArmor,
            Backpack,
            Pistol,
            Knife,
            Weapon
        }
        public enum Frequency
        {
            one = 1,
            five = 5,
            ten = 10,
            twenty_five = 25,
            fifty = 50
        }
    }
}

