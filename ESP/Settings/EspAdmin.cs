using HarmonyLib;

namespace ESP {
  public class EspAdmin : DefaultAdmin {
    public override bool Enabled {
      get => base.Enabled || (ZNet.instance && ZNet.instance.IsServer());
      set {
        base.Enabled = value;
        Drawer.CheckVisibility();
        SupportUtils.SetVisibility(Drawer.showOthers);
      }
    }
  }
  [HarmonyPatch(typeof(Console), "Awake")]
  public class Console_Awake {
    public static void Postfix(Console __instance, ref bool ___m_cheat) {
      if (!Settings.UseDebugMode) return;
      ___m_cheat = Admin.Enabled;
    }
  }
  [HarmonyPatch(typeof(Player), "Awake")]
  public class Player_Awake {
    public static void Postfix(Player __instance, ref bool ___m_noPlacementCost, ref bool ___m_debugFly) {
      if (!Admin.Enabled || !Settings.UseDebugMode) return;
      Player.m_debugMode = true;
      ___m_noPlacementCost = Settings.UseFreeBuild;
      ___m_debugFly = Settings.UseFreeFly;
      __instance.SetGodMode(Settings.UseGodMode);
    }
  }
}