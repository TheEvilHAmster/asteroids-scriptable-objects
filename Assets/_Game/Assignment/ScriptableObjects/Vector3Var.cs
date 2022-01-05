using UnityEngine;

namespace Assignment.ScriptableObjects
{
    [CreateAssetMenu(fileName = "new Vector3Var", menuName = "SOs/Vector3 Var", order = 0)]
    public class Vector3Var : ScriptableObject
    {
        [SerializeField] private Vector3 _value;

        [TextArea(3, 6)]
        [SerializeField] private string _developerDescription;
        
        public Vector3 Value => _value;

        private Vector3 _currentValue;

        private void OnEnable()
        {
            _currentValue = _value;
        }
    }
}