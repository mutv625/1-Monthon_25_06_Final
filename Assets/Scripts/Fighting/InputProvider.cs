using UniRx;
using UnityEngine;

public class InputProvider
{
    public InputProvider(IControllable controllable, KeyConfigSO keyConfig)
    {
        Debug.Log("InputProvider created");
        FightingEntryPoint.InputSubject
            .Subscribe(_ =>
            {
                // * 水平入力
                float horizontalInput = 0;
                if (Input.GetKey(keyConfig.moveLeftKey))
                {
                    horizontalInput += -1;
                }
                if (Input.GetKey(keyConfig.moveRightKey))
                {
                    horizontalInput += 1;
                }
                controllable.OnMoveInput(horizontalInput);

                // * 垂直入力
                if (Input.GetKeyDown(keyConfig.moveUpKey))
                {
                    controllable.OnJumpPressed();
                }
                if (Input.GetKeyDown(keyConfig.moveDownKey))
                {
                    // ? 下入力どうするか
                }

                // * スキル入力
                if (Input.GetKeyDown(keyConfig.skillAKey))
                {
                    controllable.OnSkillPressed(SkillType.A);
                }
                if (Input.GetKeyDown(keyConfig.skillBKey))
                {
                    controllable.OnSkillPressed(SkillType.B);
                }
            });
    }
}
