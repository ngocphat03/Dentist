using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

using Dentist.Data;

namespace Dentist
{
    public class TrashBox : Tool
    {
        private bool _haveSick = false;
        private GameObject _food;
        [SerializeField] private Transform _positionFood;
        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(!_haveSick)
            {
                Sick sick = other.gameObject.GetComponent<Sick>();
                if(sick != null && sick.TypeStick == ESick.Vegetable)
                {
                    _haveSick = true;
                    _food = other.gameObject;
                    _food.transform.SetParent(_positionFood);
                    _food.transform.localPosition = Vector3.zero;
                    sick.FixDone();
                }
            }
        }
    }  
}
