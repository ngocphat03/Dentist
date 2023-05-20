using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Dentist.Data;

namespace Dentist
{
    public class Toothbrush : Tool
    {
        protected override void Awake()
        {
            base.Awake();
            _typeTool = ETool.Toothbrush;
        }
        private void OnTriggerStay2D(Collider2D other) 
        {
            Sick sick = other.gameObject.GetComponent<Sick>();
            if(sick != null & sick.TypeStick == ESick.Plaque)
            {
                sick.DescendingSprite(0.01f);
            }
        }
    }
}
