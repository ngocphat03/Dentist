using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;
namespace Dentist
{
    public class InputDrag : MonoBehaviour
    {
        private Vector2 _transformDefaut;
        private Vector3 offset;
        private Tween _movement;
        private void Start()
        {
            _transformDefaut = transform.position;
        }
        private void OnMouseDown()
        {
            offset = transform.position - GetMouseWorldPosition();
            transform.DOScale(new Vector3(2f, 2f, 2f), 0);
            if(_movement != null)
            {
                _movement.Kill();
            }
        }
        private void OnMouseUp()
        {
            _movement = transform.DOMove(_transformDefaut, 1f);
            transform.DOScale(new Vector3(1f, 1f, 1f), 0);
            GameManager.Instance.CheckFixTooth();
        }
        private void OnMouseDrag()
        {
            Vector3 mousePos = GetMouseWorldPosition() + offset;
            transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
        }
        private Vector3 GetMouseWorldPosition()
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -Camera.main.transform.position.z;
            return Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
}
