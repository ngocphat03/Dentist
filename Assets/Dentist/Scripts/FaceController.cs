using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dentist
{
    public class FaceController : MonoBehaviour
    {
        [SerializeField] private List<Tooth> _listTooth;
        public bool finishFixAllTooth;
        public Action FinishFixAllTooth;
        private void Awake()
        {
            foreach (var tooth in _listTooth)
            {
                tooth.finishFixTooth = CheckFinishAllTooth;
            }
        }
        private void CheckFinishAllTooth()
        {
            bool allToothsFixed = true;

            foreach (Tooth tooth in _listTooth)
            {
                if (tooth.gameObject.activeInHierarchy && !tooth.FinishFix)
                {
                    allToothsFixed = false;
                    break;
                }
            }

            if (allToothsFixed)
            {
                finishFixAllTooth = true;
                // FinishFixAllTooth();
            }
        }
    }
}