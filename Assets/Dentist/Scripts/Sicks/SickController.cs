using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dentist
{
    public class SickController : MonoBehaviour
    {
        private List<Sick> _listSick = new List<Sick>();
        public Action FinishFixTooth;
        public void AddListSick(Sick newSick)
        {
            _listSick.Add(newSick);
        }
        public void RemoveSick(Sick sick)
        {
            _listSick.Remove(sick);
        }
        public void CheckFinishFixTooth()
        {
            if(_listSick.Count == 0)
            {
                FinishFixTooth();
            }
        }
    }
}