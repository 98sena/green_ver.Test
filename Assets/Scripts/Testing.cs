﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;

public class Testing : MonoBehaviour
{
    [SerializeField]
    private UI_StatsRadarChart uiStatsRadarChart;

    private void Start()
    {
        Stats stats = new Stats(10, 2, 5, 10, 3);

        uiStatsRadarChart.SetStats(stats);

        CMDebug.ButtonUI(new Vector2(100, 20), "ATK++", () => stats.IncreaseStatAmount(Stats.Type.Attack));
        CMDebug.ButtonUI(new Vector2(100, -20), "ATK--", () => stats.DecreaseStatAmount(Stats.Type.Attack));

        CMDebug.ButtonUI(new Vector2(200, 20), "DEF++", () => stats.IncreaseStatAmount(Stats.Type.Defence));
        CMDebug.ButtonUI(new Vector2(200, -20), "DEF--", () => stats.DecreaseStatAmount(Stats.Type.Defence));

        CMDebug.ButtonUI(new Vector2(300, 20), "SPD++", () => stats.IncreaseStatAmount(Stats.Type.Speed));
        CMDebug.ButtonUI(new Vector2(300, -20), "SPD--", () => stats.DecreaseStatAmount(Stats.Type.Speed));

        CMDebug.ButtonUI(new Vector2(400, 20), "MAN++", () => stats.IncreaseStatAmount(Stats.Type.Mana));
        CMDebug.ButtonUI(new Vector2(400, -20), "MAN--", () => stats.DecreaseStatAmount(Stats.Type.Mana));

        CMDebug.ButtonUI(new Vector2(500, 20), "HEL++", () => stats.IncreaseStatAmount(Stats.Type.Health));
        CMDebug.ButtonUI(new Vector2(500, -20), "HEL--", () => stats.DecreaseStatAmount(Stats.Type.Health));
    }
}
