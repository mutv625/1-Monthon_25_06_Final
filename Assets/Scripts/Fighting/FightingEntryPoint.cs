using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class FightingEntryPoint : MonoBehaviour
{
    private Initializer initializer;
    [SerializeField] private GameObject playerPrefabBase;

    private List<PlayerCore> playerCores = new List<PlayerCore>();
    private List<InputProvider> inputProviders = new List<InputProvider>();
    private List<PlayerPrefab> playerPrefabs = new List<PlayerPrefab>();

    

    [Header("入力設定")]
    [SerializeField] private List<SOKeyConfig> keyConfigs;

    private static Subject<Unit> inputSubject = new Subject<Unit>();
    public static Subject<Unit> InputSubject => inputSubject;

    void Awake()
    {
        initializer = GetComponent<Initializer>();        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // プレイヤーの脳
        playerCores.Add(initializer.SetupPlayerCore(0));
        inputProviders.Add(initializer.SetupInputProvider(playerCores[0], keyConfigs[0]));
        // プレイヤーの体(プレハブ)
        playerPrefabs.Add(Instantiate(playerPrefabBase).GetComponent<PlayerPrefab>());
        // 識別用なので
        playerPrefabs[0].PlayerID = playerCores[0].PlayerID;
        initializer.SetupPlayerMover(playerCores[0], playerPrefabs[0].gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        inputSubject?.OnNext(Unit.Default);
    }
}
