using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Dentist.Data;

namespace Dentist
{
    public class Tool : MonoBehaviour
    {
        protected ETool _typeTool;
        public ETool TypeTool => _typeTool;
        protected virtual void Awake()
        {

        }
    }
}
