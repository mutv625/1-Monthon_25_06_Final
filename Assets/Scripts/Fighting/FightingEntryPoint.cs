using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class FightingEntryPoint : MonoBehaviour
{
    private Initializer initializer;

    private List<PlayerCore> playerCores = new List<PlayerCore>();
    private List<InputProvider> inputProviders = new List<InputProvider>();

    [Header("入力設定")]
    [SerializeField] private List<KeyConfigSO> keyConfigs;

    private static Subject<Unit> inputSubject = new Subject<Unit>();
    public static Subject<Unit> InputSubject => inputSubject;

    void Awake()
    {
        initializer = GetComponent<Initializer>();        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCores.Add(initializer.SetupPlayerCore(0));
        inputProviders.Add(initializer.SetupInputProvider(playerCores[0], keyConfigs[0]));
    }

    // Update is called once per frame
    void Update()
    {
        inputSubject?.OnNext(Unit.Default);
    }
}
