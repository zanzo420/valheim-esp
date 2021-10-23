using BepInEx.Configuration;
using UnityEngine;
using Visualization;

namespace ESP {
  public partial class Settings {
    public static Color ParseColor(string color) {
      if (ColorUtility.TryParseHtmlString(color, out var parsed)) return parsed;
      return Color.white;
    }
    public static ConfigEntry<string> configCreatureRayColor;
    public static ConfigEntry<string> configPickableOneTimeColor;
    public static ConfigEntry<string> configPickableRespawningColor;
    public static ConfigEntry<string> configLocationRayColor;
    public static ConfigEntry<string> configChestRayColor;
    public static ConfigEntry<string> configOreRayColor;
    public static ConfigEntry<string> configTreeRayColor;
    public static ConfigEntry<string> configDestructibleRayColor;
    public static ConfigEntry<string> configSpawnPointOneTimeColor;
    public static ConfigEntry<string> configSpawnPointRespawningColor;
    public static ConfigEntry<string> configNoiseColor;
    public static ConfigEntry<string> configCoverRayColor;
    public static ConfigEntry<string> configCoverRayBlockedColor;
    public static ConfigEntry<string> configCreatureHearColor;
    public static ConfigEntry<string> configCreatureViewColor;
    public static ConfigEntry<string> configCreatureAlertViewColor;
    public static ConfigEntry<string> configCreatureFireLimitColor;
    public static ConfigEntry<string> configCreatureTotalLimitColor;
    public static ConfigEntry<string> configCreaturePartnerCheckColor;
    public static ConfigEntry<string> configCreatureFoodCheckColor;
    public static ConfigEntry<string> configCreatureEatRangeColor;
    public static ConfigEntry<string> configRulerColor;
    public static ConfigEntry<string> configSpawnerRayColor;
    public static ConfigEntry<string> configSpawnerTriggerColor;
    public static ConfigEntry<string> configSpawnerNearColor;
    public static ConfigEntry<string> configSpawnerSpawnColor;
    public static ConfigEntry<string> configEffectAreaPrivateAreaColor;
    public static ConfigEntry<string> configEffectAreaComfortColor;
    public static ConfigEntry<string> configEffectAreaBurningColor;
    public static ConfigEntry<string> configEffectAreaHeatColor;
    public static ConfigEntry<string> configEffectAreaFireColor;
    public static ConfigEntry<string> configEffectAreaNoMonstersColor;
    public static ConfigEntry<string> configEffectAreaTeleportColor;
    public static ConfigEntry<string> configEffectAreaPlayerBaseColor;
    public static ConfigEntry<string> configEffectAreaOtherColor;
    public static ConfigEntry<string> configEffectAreaWarmCozyColor;
    public static ConfigEntry<string> configEffectAreaCustomContainerColor;
    public static ConfigEntry<string> configEffectAreaCustomCraftingColor;
    public static ConfigEntry<string> configSmokeColor;
    public static ConfigEntry<string> configRandomEventSystemRayColor;
    public static ConfigEntry<string> configBiomeAshlandsColor;
    public static ConfigEntry<string> configBiomeBlackForestColor;
    public static ConfigEntry<string> configBiomeDeepNorthColor;
    public static ConfigEntry<string> configBiomeMeadowsColor;
    public static ConfigEntry<string> configBiomeMistlandsColor;
    public static ConfigEntry<string> configBiomeMountainColor;
    public static ConfigEntry<string> configBiomeOceanColor;
    public static ConfigEntry<string> configBiomePlainsColor;
    public static ConfigEntry<string> configBiomeSwampColor;
    public static ConfigEntry<string> configBiomeOtherColor;
    private static void OnColorChanged(ConfigEntry<string> entry, string tag) {
      entry.SettingChanged += (s, e) => Draw.SetColor(tag, ParseColor(entry.Value));
      Draw.SetColor(tag, ParseColor(entry.Value));
    }
    private static void InitColors(ConfigFile config) {
      var section = "6. Colors (predefined, #RRGGBB, #RRGGBBAA)";
      configCreatureRayColor = config.Bind(section, "Creature ray", "magenta", "");
      OnColorChanged(configCreatureRayColor, Tag.TrackedCreature);
      configPickableOneTimeColor = config.Bind(section, "Pickable ray (one time)", "green", "");
      OnColorChanged(configPickableOneTimeColor, Tag.PickableOneTime);
      configPickableRespawningColor = config.Bind(section, "Pickable ray (respawning)", "blue", "");
      OnColorChanged(configPickableRespawningColor, Tag.PickableRespawning);
      configLocationRayColor = config.Bind(section, "Location ray", "black", "");
      OnColorChanged(configLocationRayColor, Tag.Location);
      configChestRayColor = config.Bind(section, "Chest ray", "white", "");
      OnColorChanged(configChestRayColor, Tag.Chest);
      configOreRayColor = config.Bind(section, "Ore ray", "gray", "");
      OnColorChanged(configOreRayColor, Tag.Ore);
      configTreeRayColor = config.Bind(section, "Tree ray", "white", "");
      OnColorChanged(configTreeRayColor, Tag.Tree);
      configDestructibleRayColor = config.Bind(section, "Destructible ray", "white", "");
      OnColorChanged(configDestructibleRayColor, Tag.Destructible);
      configSpawnPointOneTimeColor = config.Bind(section, "Spawn point ray (one time)", "red", "");
      OnColorChanged(configSpawnPointOneTimeColor, Tag.SpawnPointOneTime);
      configSpawnPointRespawningColor = config.Bind(section, "Spawn point ray (respawning)", "yellow", "");
      OnColorChanged(configSpawnPointRespawningColor, Tag.SpawnPointRespawning);
      configNoiseColor = config.Bind(section, "Noise sphere", "cyan", "");
      OnColorChanged(configNoiseColor, Tag.CreatureNoise);
      configCoverRayColor = config.Bind(section, "Cover ray", "green", "");
      OnColorChanged(configCoverRayColor, Tag.StructureCover);
      OnColorChanged(configCoverRayColor, Tag.PlayerCover);
      configCoverRayBlockedColor = config.Bind(section, "Cover ray (blocked)", "red", "");
      OnColorChanged(configCoverRayBlockedColor, Tag.StructureCoverBlocked);
      OnColorChanged(configCoverRayBlockedColor, Tag.PlayerCoverBlocked);
      configCreatureHearColor = config.Bind(section, "Creature hearing sphere", "green", "");
      OnColorChanged(configCreatureHearColor, Tag.CreatureHearRange);
      configCreatureViewColor = config.Bind(section, "Creature sight cone", "white", "");
      OnColorChanged(configCreatureViewColor, Tag.CreatureViewRange);
      configCreatureAlertViewColor = config.Bind(section, "Creature alert sight cone", "red", "");
      OnColorChanged(configCreatureAlertViewColor, Tag.CreatureAlertRange);
      configCreatureFireLimitColor = config.Bind(section, "Creature fire limit sphere", "magenta", "");
      OnColorChanged(configCreatureFireLimitColor, Tag.CreatureFireRange);
      configCreatureTotalLimitColor = config.Bind(section, "Creature total limit sphere", "cyan", "");
      OnColorChanged(configCreatureTotalLimitColor, Tag.CreatureBreedingTotalRange);
      configCreaturePartnerCheckColor = config.Bind(section, "Creature partner check sphere", "magenta", "");
      OnColorChanged(configCreaturePartnerCheckColor, Tag.CreatureBreedingPartnerRange);
      configCreatureFoodCheckColor = config.Bind(section, "Creature food check sphere", "gray", "");
      OnColorChanged(configCreatureFoodCheckColor, Tag.CreatureFoodSearchRange);
      configCreatureEatRangeColor = config.Bind(section, "Creature eat range sphere", "black", "");
      OnColorChanged(configCreatureEatRangeColor, Tag.CreatureEatingRange);
      configRulerColor = config.Bind(section, "Ruler", "red", "");
      OnColorChanged(configRulerColor, Tag.Ruler);
      configSpawnerRayColor = config.Bind(section, "Spawner ray", "red", "");
      OnColorChanged(configSpawnerRayColor, Tag.SpawnerRay);
      configSpawnerTriggerColor = config.Bind(section, "Spawner trigger sphere", "red", "");
      OnColorChanged(configSpawnerTriggerColor, Tag.SpawnerTriggerRange);
      configSpawnerNearColor = config.Bind(section, "Spawner near limit sphere", "white", "");
      OnColorChanged(configSpawnerNearColor, Tag.SpawnerLimitRange);
      configSpawnerSpawnColor = config.Bind(section, "Spawner spawn sphere", "cyan", "");
      OnColorChanged(configSpawnerSpawnColor, Tag.SpawnerSpawnRange);
      configEffectAreaPrivateAreaColor = config.Bind(section, "Ward effect sphere", "gray", "");
      OnColorChanged(configEffectAreaPrivateAreaColor, Tag.EffectAreaPlayerBase);
      configEffectAreaComfortColor = config.Bind(section, "Comfort effect sphere", "cyan", "");
      OnColorChanged(configEffectAreaComfortColor, Tag.EffectAreaComfort);
      configEffectAreaBurningColor = config.Bind(section, "Burning effect sphere", "yellow", "");
      OnColorChanged(configEffectAreaBurningColor, Tag.EffectAreaBurning);
      configEffectAreaHeatColor = config.Bind(section, "Heat effect sphere", "magenta", "");
      OnColorChanged(configEffectAreaHeatColor, Tag.EffectAreaHeat);
      configEffectAreaFireColor = config.Bind(section, "Fire effect sphere", "red", "");
      OnColorChanged(configEffectAreaFireColor, Tag.EffectAreaFire);
      configEffectAreaNoMonstersColor = config.Bind(section, "No monsters effect sphere", "green", "");
      OnColorChanged(configEffectAreaNoMonstersColor, Tag.EffectAreaNoMonsters);
      configEffectAreaTeleportColor = config.Bind(section, "Teleport effect sphere", "blue", "");
      OnColorChanged(configEffectAreaTeleportColor, Tag.EffectAreaTeleport);
      configEffectAreaPlayerBaseColor = config.Bind(section, "Player base effect sphere", "white", "");
      OnColorChanged(configEffectAreaPlayerBaseColor, Tag.EffectAreaPlayerBase);
      configEffectAreaOtherColor = config.Bind(section, "Unknown effect spheres", "black", "");
      OnColorChanged(configEffectAreaOtherColor, Tag.EffectAreaOther);
      configEffectAreaWarmCozyColor = config.Bind(section, "Warm and cozy effect sphere", "magenta", "");
      OnColorChanged(configEffectAreaWarmCozyColor, Tag.EffectAreaWarmCozy);
      configEffectAreaCustomContainerColor = config.Bind(section, "Custom container sphere", "yellow", "");
      OnColorChanged(configEffectAreaCustomContainerColor, Tag.EffectAreaCustomContainer);
      configEffectAreaCustomCraftingColor = config.Bind(section, "Custom crafting station sphere", "yellow", "");
      OnColorChanged(configEffectAreaCustomCraftingColor, Tag.EffectAreaCustomCrafting);
      configSmokeColor = config.Bind(section, "Smoke sphere", "black", "");
      OnColorChanged(configSmokeColor, Tag.Smoke);
      configRandomEventSystemRayColor = config.Bind(section, "Random even system ray", "black", "");
      OnColorChanged(configRandomEventSystemRayColor, Tag.RandomEventSystem);
      configBiomeAshlandsColor = config.Bind(section, "Ashlands color", "red", "");
      OnColorChanged(configBiomeAshlandsColor, Tag.ZoneCornerAshlands);
      OnColorChanged(configBiomeAshlandsColor, Tag.SpawnZoneAshlands);
      configBiomeBlackForestColor = config.Bind(section, "Black Forest color", "magenta", "");
      OnColorChanged(configBiomeBlackForestColor, Tag.ZoneCornerBlackForest);
      OnColorChanged(configBiomeBlackForestColor, Tag.SpawnZoneBlackForest);
      configBiomeDeepNorthColor = config.Bind(section, "Deep North color", "gray", "");
      OnColorChanged(configBiomeDeepNorthColor, Tag.ZoneCornerDeepNorth);
      OnColorChanged(configBiomeDeepNorthColor, Tag.SpawnZoneDeepNorth);
      configBiomeMeadowsColor = config.Bind(section, "Meadows color", "green", "");
      OnColorChanged(configBiomeMeadowsColor, Tag.ZoneCornerMeadows);
      OnColorChanged(configBiomeMeadowsColor, Tag.SpawnZoneMeadows);
      configBiomeMistlandsColor = config.Bind(section, "Mistlands color", "gray", "");
      OnColorChanged(configBiomeMistlandsColor, Tag.ZoneCornerMistlands);
      OnColorChanged(configBiomeMistlandsColor, Tag.SpawnZoneMistlands);
      configBiomeMountainColor = config.Bind(section, "Mountain color", "white", "");
      OnColorChanged(configBiomeMountainColor, Tag.ZoneCornerMountain);
      OnColorChanged(configBiomeMountainColor, Tag.SpawnZoneMountain);
      configBiomeOceanColor = config.Bind(section, "Ocean color", "blue", "");
      OnColorChanged(configBiomeOceanColor, Tag.ZoneCornerOcean);
      OnColorChanged(configBiomeOceanColor, Tag.SpawnZoneOcean);
      configBiomePlainsColor = config.Bind(section, "Plains color", "yellow", "");
      OnColorChanged(configBiomePlainsColor, Tag.ZoneCornerPlains);
      OnColorChanged(configBiomePlainsColor, Tag.SpawnZonePlains);
      configBiomeSwampColor = config.Bind(section, "Swamp color", "cyan", "");
      OnColorChanged(configBiomeSwampColor, Tag.ZoneCornerSwamp);
      OnColorChanged(configBiomeSwampColor, Tag.SpawnZoneSwamp);
      configBiomeOtherColor = config.Bind(section, "Unknown biome color", "black", "");
      OnColorChanged(configBiomeOtherColor, Tag.ZoneCornerUnknown);
      OnColorChanged(configBiomeOtherColor, Tag.SpawnZoneUnknown);
    }
  }
}
