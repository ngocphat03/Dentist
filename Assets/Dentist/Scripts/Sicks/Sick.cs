using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Dentist.Data;

namespace Dentist
{
    public class Sick : MonoBehaviour
    {
        [SerializeField] protected SpriteRenderer _spriteRender;
        [SerializeField] protected ESick _typeSick;
        public ESick TypeStick => _typeSick;
        public bool IsDone => _isDone;
        protected bool _isDone;
        protected Color _spriteColor;
        public Action FinishFixStick;
        protected virtual void Start()
        {
            _spriteColor = _spriteRender.color;
            GameManager.Instance.AddNewSick(this);
            _isDone = false;
        }
        protected virtual void OnEnable() 
        {
        }
        protected virtual void OnDisable()
        {
            GameManager.Instance.RemoveSick(this);
        }
        public virtual void DescendingSprite(float anpha)
        {
            if(_isDone) return;
            _spriteColor.a -= anpha;
            _spriteRender.color = _spriteColor;
            _isDone = _spriteColor.a <= 0 ? true : false;
            if(_isDone)
            {
                FinishFixStick();
                FixDone();
            } 
        }
        public void FixDone()
        {
            _isDone = true;
            this.gameObject.SetActive(false);
        }
    }
}