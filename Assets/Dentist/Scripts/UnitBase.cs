using UnityEngine;

using Dentist.Data;

namespace Dentist
{
    public class UnitBase : MonoBehaviour
    {
        [SerializeField] protected int _indexTooth;
        [SerializeField] protected Sick _sick;
        protected bool _finishFix;
        protected bool _isCaries;
        public bool FinishFix => _finishFix;
        public Sick Sick => _sick;
        public void FinishFixSick()
        {
            _finishFix = true;
        }
    }
}
