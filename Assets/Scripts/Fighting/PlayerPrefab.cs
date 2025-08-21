using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    [Header("PlayerID 識別用?")]
    [SerializeField] private int playerID;
    public int PlayerID { get => playerID; set => playerID = value; }

    // [SerializeField] private PlayerCore playerCore;
    // public PlayerCore PlayerCore { get => playerCore; set => playerCore = value; }
}
