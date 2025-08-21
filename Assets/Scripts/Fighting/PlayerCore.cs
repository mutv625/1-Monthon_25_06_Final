using UnityEngine;
using UniRx;
using System;

public class PlayerCore : IControllable
{
    // * PlayerCore が持つべき情報は…
    [SerializeField] private int playerID;
    public int PlayerID => playerID;

    public PlayerCore(int playerID)
    {
        this.playerID = playerID;
    }

    // ! 入力 → 移動・スキル管理

    [SerializeField] private float _speed = 5f;
    public float Speed
    { get => _speed; set => _speed = value; }

    [SerializeField] private float _jumpForce = 10f;
    public float JumpForce { get => _jumpForce; set => _jumpForce = value; }

    private Subject<float> _eventOnMove = new Subject<float>();
    public IObservable<float> EventWhenMoving => _eventOnMove.AsObservable();

    private Subject<float> _eventOnJump = new Subject<float>();
    public IObservable<float> EventOnJump => _eventOnJump.AsObservable();

    public void OnMoveInput(float horizontal)
    {
        if (horizontal != 0)
        {
            Debug.Log($"Player {playerID} moving with input: {horizontal}");
        }
        _eventOnMove.OnNext(horizontal * Speed);
    }

    public void OnJumpPressed()
    {
        Debug.Log($"Player {playerID} jumped");
        _eventOnJump.OnNext(JumpForce);
    }

    public void OnSkillPressed(SkillType skillType)
    {
        Debug.Log($"Player {playerID} used skill: {skillType}");
        // TODO: Implement skill activation logic
    }
}
