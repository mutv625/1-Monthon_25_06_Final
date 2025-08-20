using UnityEngine;

public class SOFighterPayload : ScriptableObject
{
    // This class is a placeholder for the fighter payload data.
    // It can be extended to include properties and methods relevant to the fighter's payload.
    [SerializeField] private string fighterID;
    [SerializeField] private string fighterName;

    [SerializeField] private int initialHealth;

    public string FighterName => fighterName;
    public int InitialHealth => initialHealth;

    // Additional properties and methods can be added as needed.
}
