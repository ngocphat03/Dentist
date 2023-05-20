using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dentist
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private FaceController _faceController;
        [SerializeField] public SickController _sickController;
        public static GameManager Instance;
        private void Awake()
        {
            Instance = this;
            _sickController.FinishFixTooth = WinGame;
        }
        private void WinGame()
        {
            Debug.LogError("You Win");
        }
        public void AddNewSick(Sick sick)
        {
            _sickController.AddListSick(sick);
        }
        public void RemoveSick(Sick sick)
        {
            _sickController.RemoveSick(sick);
        }
        public void CheckFixTooth()
        {
            _sickController.CheckFinishFixTooth();
        }
    }
}
