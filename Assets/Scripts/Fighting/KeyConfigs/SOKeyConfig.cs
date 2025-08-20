using UnityEngine;

[CreateAssetMenu(fileName = "KeyConfig", menuName = "SO Configs/KeyConfig")]
public class SOKeyConfig : ScriptableObject
{
    [SerializeField] public KeyCode moveUpKey;
    [SerializeField] public KeyCode moveDownKey;
    [SerializeField] public KeyCode moveLeftKey;
    [SerializeField] public KeyCode moveRightKey;
    [SerializeField] public KeyCode skillAKey;
    [SerializeField] public KeyCode skillBKey;
}
