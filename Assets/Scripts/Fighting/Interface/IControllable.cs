using System;
using UniRx;

public enum SkillType
{
    A,
    B
}

public interface IControllable
{
    public IObservable<float> EventWhenMoving { get; }
    public IObservable<float> EventOnJump { get; }

    void OnMoveInput(float horizontal);

    void OnJumpPressed();

    void OnSkillPressed(SkillType skillType);
}
