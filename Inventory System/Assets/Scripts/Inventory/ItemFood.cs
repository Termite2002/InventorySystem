using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Inventory
{
    [CreateAssetMenu(fileName = "FoodName", menuName = "Item/New Food")]
    public class ItemFood : Item
    {
        [Header("Food Components")]
        public FoodType foodType;
        public int energy;

        public enum FoodType
        {
            Food,
            Drink
        }
    }
}

