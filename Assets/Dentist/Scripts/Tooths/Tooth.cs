using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dentist
{
    public class Tooth : UnitBase
    {
        [SerializeField] private Transform _transformStick;
        public Action finishFixTooth;
        private void Awake()
        {
            if(_sick)
            {
                _sick.FinishFixStick = FixTooth;
            }
            else
            {
                _finishFix = true;
            }
        }
        public void FixTooth()
        {
            _finishFix = true;
            finishFixTooth();
        }
    }
}