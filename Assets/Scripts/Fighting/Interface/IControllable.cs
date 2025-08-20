public enum SkillType
{
    A,
    B
}

public interface IControllable
{
    void OnMoveInput(float horizontal);

    void OnJumpPressed();

    void OnSkillPressed(SkillType skillType);
}
