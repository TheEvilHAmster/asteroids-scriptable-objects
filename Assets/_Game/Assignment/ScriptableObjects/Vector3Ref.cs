using UnityEngine;

namespace Assignment.ScriptableObjects
{
    public class Vector3Ref : MonoBehaviour
    {
        [SerializeField] private bool _useSimpleValue;
        
        [SerializeField] private Vector3Var _variableNewName;
        [SerializeField] private Vector3 _simpleValue;
        
        public Vector3 Value => _useSimpleValue ? _simpleValue : _variableNewName.Value;

#if UNITY_EDITOR
        public static string VariableName = nameof(_variableNewName);
        public static string UseSimpleValueName = nameof(_useSimpleValue); // "_useSimpleValue"
        public static string SimpleValueName = nameof(_simpleValue);
#endif
    }
}