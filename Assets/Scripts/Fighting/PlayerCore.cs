using UnityEngine;

public class PlayerCore : IControllable
{
    // * PlayerCore が持つべき情報は…
    [SerializeField] private int playerID;
    public int PlayerID => playerID;

    public PlayerCore(int playerID)
    {
        this.playerID = playerID;
    }


    public void OnMoveInput(float horizontal)
    {
        // TODO: Implement movement logic
        if (horizontal != 0)
        {
            Debug.Log($"Player {playerID} moving with input: {horizontal}");
        }
    }

    public void OnJumpPressed()
    {
        // TODO: Implement jump logic
        Debug.Log($"Player {playerID} jumped");
    }

    public void OnSkillPressed(SkillType skillType)
    {
        // TODO: Implement skill activation logic
        Debug.Log($"Player {playerID} used skill: {skillType}");
    }
}
