using UnityEngine;

[CreateAssetMenu(fileName = "KeyConfig", menuName = "ScriptableObjects/KeyConfig")]
public class KeyConfigSO : ScriptableObject
{
    [SerializeField] public KeyCode moveUpKey;
    [SerializeField] public KeyCode moveDownKey;
    [SerializeField] public KeyCode moveLeftKey;
    [SerializeField] public KeyCode moveRightKey;
    [SerializeField] public KeyCode skillAKey;
    [SerializeField] public KeyCode skillBKey;
}
