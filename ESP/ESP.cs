﻿using Authorization;
using BepInEx;
using HarmonyLib;
using Visualization;

namespace ESP {
  [BepInDependency("valheim.jerekuusela.dps", BepInDependency.DependencyFlags.SoftDependency)]
  [BepInPlugin("valheim.jerekuusela.esp", "ESP", "1.5.0.0")]
  public class ESP : BaseUnityPlugin {
    public void Awake() {
      Settings.Init(Config);
      var harmony = new Harmony("valheim.jerekuusela.esp");
      harmony.PatchAll();
      Admin.Instance = new EspAdmin();
      SetupTagGroups();
    }

    private void SetupTagGroups() {
      Visibility.AddTag(Tag.TrackedCreature);
      Visibility.AddTag(Tag.CreatureAlertRange);
      Visibility.AddTag(Tag.CreatureBreedingPartnerRange);
      Visibility.AddTag(Tag.CreatureBreedingTotalRange);
      Visibility.AddTag(Tag.CreatureEatingRange);
      Visibility.AddTag(Tag.CreatureFireRange);
      Visibility.AddTag(Tag.CreatureFoodSearchRange);
      Visibility.AddTag(Tag.CreatureHearRange);
      Visibility.AddTag(Tag.CreatureNoise);
      Visibility.AddTag(Tag.CreatureViewRange);
      Visibility.AddTag(Tag.Chest);
      Visibility.AddTag(Tag.StructureCover);
      Visibility.AddTag(Tag.SpawnPoint);
      Visibility.AddTag(Tag.Destructible);
      Visibility.AddTag(Tag.EffectArea);
      Visibility.AddTag(Tag.Location);
      Visibility.AddTag(Tag.Ore);
      Visibility.AddTag(Tag.Pickable);
      Visibility.AddTag(Tag.RandomEventSystem);
      Visibility.AddTag(Tag.Smoke);
      Visibility.AddTag(Tag.Spawner);
      Visibility.AddTag(Tag.SpawnZone);
      Visibility.AddTag(Tag.StructureSupport);
      Visibility.AddTag(Tag.Tree);
      Visibility.AddTag(Tag.ZoneCorner);
    }
    public void LateUpdate() {
      if (Player.m_localPlayer)
        Texts.UpdateAverageSpeed(Ship.GetLocalShip());
    }
  }

  [HarmonyPatch(typeof(Chat), "Awake")]
  public class ChatBind {
    public static void Postfix(Console __instance) {
      if (!Settings.configFirstRun.Value) return;
      Settings.configFirstRun.Value = false;
      var binds = Patch.BindList(__instance);
      if (binds == null) UnityEngine.Debug.LogError("No binds!");
      while (true) {
        var index = binds.FindIndex(item => item.Contains("esp_"));
        if (index == -1) break;
        binds.RemoveAt(index);
      }
      __instance.TryRunCommand("bind o esp_toggle " + Tool.ExtraInfo);
      __instance.TryRunCommand("bind j esp_toggle " + Tool.Ruler);
    }
  }
}
