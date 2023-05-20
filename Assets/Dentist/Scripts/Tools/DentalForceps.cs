using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Dentist.Data;
namespace Dentist
{
    public class DentalForceps : Tool
    {
        [SerializeField] private Transform _transformObject;
        private GameObject _food;
        private bool _haveSick = false;
        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(!_haveSick)
            {
                Sick sick = other.gameObject.GetComponent<Sick>();
                if(sick != null && sick.TypeStick == ESick.Vegetable)
                {
                    _haveSick = true;
                    _food = other.gameObject;
                    _food.transform.SetParent(_transformObject);
                    _food.transform.localPosition = Vector3.zero;
                }
            }
        }
    }
}
