﻿using System;
using BepInEx.Configuration;
using Visualization;

namespace ESP {
  public partial class Settings {
    public static ConfigEntry<int> configShowCreatureFireRange;
    public static ConfigEntry<int> configShowTrackedCreatures;
    public static ConfigEntry<int> configShowCreatureBreedingTotalRange;
    public static ConfigEntry<int> configShowCreatureBreedingPartnerRange;
    public static ConfigEntry<int> configShowCreatureFoodSearchRange;
    public static ConfigEntry<int> configShowCreatureEatingRange;
    public static ConfigEntry<int> configShowStructureCover;
    public static ConfigEntry<int> configShowPlayerCover;
    public static ConfigEntry<int> configShowSmoke;
    public static ConfigEntry<int> configShowCreatureAlertRange;
    public static ConfigEntry<int> configShowCreatureNoise;
    public static ConfigEntry<int> configShowCreatureHearRange;
    public static ConfigEntry<int> configShowCreatureViewRange;
    public static ConfigEntry<int> configShowSpawnZones;
    public static ConfigEntry<int> configShowRandomEventSystem;
    public static ConfigEntry<int> configShowSpawnerRays;
    public static ConfigEntry<int> configShowSpawnerTriggerRanges;
    public static ConfigEntry<int> configShowSpawnerLimitRanges;
    public static ConfigEntry<int> configShowSpawnerSpawnRanges;
    public static ConfigEntry<int> configShowSpawnPointsOneTime;
    public static ConfigEntry<int> configShowSpawnPointsRespawning;
    public static ConfigEntry<int> configShowZoneCorners;
    public static ConfigEntry<int> configShowPickablesOneTime;
    public static ConfigEntry<int> configShowPickablesRespawning;
    public static ConfigEntry<int> configShowEffectAreasPrivateArea;
    public static ConfigEntry<int> configShowEffectAreasComfort;
    public static ConfigEntry<int> configShowEffectAreasBurning;
    public static ConfigEntry<int> configShowEffectAreasHeat;
    public static ConfigEntry<int> configShowEffectAreasFire;
    public static ConfigEntry<int> configShowEffectAreasNoMonsters;
    public static ConfigEntry<int> configShowEffectAreasTeleport;
    public static ConfigEntry<int> configShowEffectAreasPlayerBase;
    public static ConfigEntry<int> configShowEffectAreasWarmCozy;
    public static ConfigEntry<int> configShowEffectAreasOther;
    public static ConfigEntry<int> configShowEffectAreasCustomContainer;
    public static ConfigEntry<int> configShowEffectAreasCustomCrafting;
    public static ConfigEntry<int> configShowChests;
    public static ConfigEntry<int> configShowOres;
    public static ConfigEntry<int> configShowTrees;
    public static ConfigEntry<int> configShowDestructibles;
    public static ConfigEntry<int> configShowLocations;
    public static ConfigEntry<int> configShowStructureSupport;
    private static ConfigEntry<int> GetTagEntry(string name) {
      name = name.ToLower();
      if (name == Tag.StructureCover.ToLower()) return configShowStructureCover;
      if (name == Tag.StructureCoverBlocked.ToLower()) return configShowStructureCover;
      if (name == Tag.StructureSupport.ToLower()) return configShowStructureSupport;
      if (name == Tag.CreatureNoise.ToLower()) return configShowCreatureNoise;
      if (name == Tag.CreatureHearRange.ToLower()) return configShowCreatureHearRange;
      if (name == Tag.CreatureViewRange.ToLower()) return configShowCreatureViewRange;
      if (name == Tag.CreatureAlertRange.ToLower()) return configShowCreatureAlertRange;
      if (name == Tag.CreatureFireRange.ToLower()) return configShowCreatureFireRange;
      if (name == Tag.CreatureBreedingTotalRange.ToLower()) return configShowCreatureBreedingTotalRange;
      if (name == Tag.CreatureBreedingPartnerRange.ToLower()) return configShowCreatureBreedingPartnerRange;
      if (name == Tag.CreatureFoodSearchRange.ToLower()) return configShowCreatureFoodSearchRange;
      if (name == Tag.CreatureEatingRange.ToLower()) return configShowCreatureEatingRange;
      if (name == Tag.TrackedCreature.ToLower()) return configShowTrackedCreatures;
      if (name == Tag.PickableOneTime.ToLower()) return configShowPickablesOneTime;
      if (name == Tag.PickableRespawning.ToLower()) return configShowPickablesRespawning;
      if (name == Tag.Location.ToLower()) return configShowLocations;
      if (name == Tag.Chest.ToLower()) return configShowChests;
      if (name == Tag.Tree.ToLower()) return configShowTrees;
      if (name == Tag.Ore.ToLower()) return configShowOres;
      if (name == Tag.Destructible.ToLower()) return configShowDestructibles;
      if (name == Tag.SpawnPointOneTime.ToLower()) return configShowSpawnPointsOneTime;
      if (name == Tag.SpawnPointRespawning.ToLower()) return configShowSpawnPointsRespawning;
      if (name == Tag.SpawnerRay.ToLower()) return configShowSpawnerRays;
      if (name == Tag.SpawnerTriggerRange.ToLower()) return configShowSpawnerTriggerRanges;
      if (name == Tag.SpawnerLimitRange.ToLower()) return configShowSpawnerLimitRanges;
      if (name == Tag.SpawnerSpawnRange.ToLower()) return configShowSpawnerSpawnRanges;
      if (name == Tag.ZoneCorner.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerAshlands.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerBlackForest.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerDeepNorth.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerMeadows.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerMistlands.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerMountain.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerOcean.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerPlains.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerSwamp.ToLower()) return configShowZoneCorners;
      if (name == Tag.ZoneCornerUnknown.ToLower()) return configShowZoneCorners;
      if (name == Tag.SpawnZone.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneAshlands.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneBlackForest.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneDeepNorth.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneMeadows.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneMistlands.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneMountain.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneOcean.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZonePlains.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneSwamp.ToLower()) return configShowSpawnZones;
      if (name == Tag.SpawnZoneUnknown.ToLower()) return configShowSpawnZones;
      if (name == Tag.RandomEventSystem.ToLower()) return configShowRandomEventSystem;
      if (name == Tag.EffectAreaBurning.ToLower()) return configShowEffectAreasBurning;
      if (name == Tag.EffectAreaComfort.ToLower()) return configShowEffectAreasComfort;
      if (name == Tag.EffectAreaCustomContainer.ToLower()) return configShowEffectAreasCustomContainer;
      if (name == Tag.EffectAreaCustomCrafting.ToLower()) return configShowEffectAreasCustomCrafting;
      if (name == Tag.EffectAreaFire.ToLower()) return configShowEffectAreasFire;
      if (name == Tag.EffectAreaHeat.ToLower()) return configShowEffectAreasHeat;
      if (name == Tag.EffectAreaNoMonsters.ToLower()) return configShowEffectAreasNoMonsters;
      if (name == Tag.EffectAreaOther.ToLower()) return configShowEffectAreasOther;
      if (name == Tag.EffectAreaPlayerBase.ToLower()) return configShowEffectAreasPlayerBase;
      if (name == Tag.EffectAreaWarmCozy.ToLower()) return configShowEffectAreasWarmCozy;
      if (name == Tag.EffectAreaPrivateArea.ToLower()) return configShowEffectAreasPrivateArea;
      if (name == Tag.EffectAreaTeleport.ToLower()) return configShowEffectAreasTeleport;
      if (name == Tag.Smoke.ToLower()) return configShowSmoke;
      if (name == Tag.PlayerCover.ToLower()) return configShowPlayerCover;
      if (name == Tag.PlayerCoverBlocked.ToLower()) return configShowPlayerCover;
      throw new NotImplementedException(name);
    }
    public static bool IsDisabled(string name) => GetTagEntry(name).Value < 0;
    private static ConfigDescription CreateDescription() => new ConfigDescription("", new AcceptableValueRange<int>(-1, 1));
    private static void OnChanged(ConfigEntry<int> entry, string tag) {
      entry.SettingChanged += (s, e) => Visibility.SetTag(tag, entry.Value > 0);
      Visibility.SetTag(tag, entry.Value > 0);
    }
    private static void InitVisuals(ConfigFile config) {
      var section = "4. Visuals";

      configShowStructureCover = config.Bind(section, "Structure cover", 1, CreateDescription());
      OnChanged(configShowStructureCover, Tag.StructureCover);
      OnChanged(configShowStructureCover, Tag.StructureCoverBlocked);
      configShowStructureCover.SettingChanged += (s, e) => SupportUtils.UpdateVisibility();
      configShowStructureSupport = config.Bind(section, "Structure support", 1, CreateDescription());
      OnChanged(configShowStructureSupport, Tag.StructureSupport);
      configShowCreatureNoise = config.Bind(section, "Creature noise", 1, CreateDescription());
      OnChanged(configShowCreatureNoise, Tag.CreatureNoise);
      configShowCreatureHearRange = config.Bind(section, "Creature hear range", 1, CreateDescription());
      OnChanged(configShowCreatureHearRange, Tag.CreatureHearRange);
      configShowCreatureViewRange = config.Bind(section, "Creature vuew range", 1, CreateDescription());
      OnChanged(configShowCreatureViewRange, Tag.CreatureViewRange);
      configShowCreatureAlertRange = config.Bind(section, "Creature alert range", 1, CreateDescription());
      OnChanged(configShowCreatureAlertRange, Tag.CreatureAlertRange);
      configShowCreatureFireRange = config.Bind(section, "Creature fire range", 1, CreateDescription());
      OnChanged(configShowCreatureFireRange, Tag.CreatureFireRange);
      configShowCreatureBreedingTotalRange = config.Bind(section, "Creature breeding total range", 1, CreateDescription());
      OnChanged(configShowCreatureBreedingTotalRange, Tag.CreatureBreedingTotalRange);
      configShowCreatureBreedingPartnerRange = config.Bind(section, "Creature breeding partner range", 1, CreateDescription());
      OnChanged(configShowCreatureBreedingPartnerRange, Tag.CreatureBreedingPartnerRange);
      configShowCreatureEatingRange = config.Bind(section, "Creature eating range", 1, CreateDescription());
      OnChanged(configShowCreatureEatingRange, Tag.CreatureEatingRange);
      configShowCreatureFoodSearchRange = config.Bind(section, "Creature food search range", 1, CreateDescription());
      OnChanged(configShowCreatureFoodSearchRange, Tag.CreatureFoodSearchRange);
      configShowTrackedCreatures = config.Bind(section, "Tracked creature rays", 1, CreateDescription());
      OnChanged(configShowTrackedCreatures, Tag.TrackedCreature);
      configShowPickablesOneTime = config.Bind(section, "Pickable rays (one time)", 1, CreateDescription());
      OnChanged(configShowPickablesOneTime, Tag.PickableOneTime);
      configShowPickablesRespawning = config.Bind(section, "Pickable rays (respawning)", 1, CreateDescription());
      OnChanged(configShowPickablesRespawning, Tag.PickableRespawning);
      configShowLocations = config.Bind(section, "Location rays", 1, CreateDescription());
      OnChanged(configShowLocations, Tag.Location);
      configShowChests = config.Bind(section, "Chest rays", 1, CreateDescription());
      OnChanged(configShowChests, Tag.Chest);
      configShowTrees = config.Bind(section, "Tree rays", 1, CreateDescription());
      OnChanged(configShowTrees, Tag.Tree);
      configShowOres = config.Bind(section, "Ore rays", 1, CreateDescription());
      OnChanged(configShowOres, Tag.Ore);
      configShowDestructibles = config.Bind(section, "Destructible rays", 1, CreateDescription());
      OnChanged(configShowDestructibles, Tag.Destructible);
      configShowSpawnPointsOneTime = config.Bind(section, "Spawn points (one time)", 1, CreateDescription());
      OnChanged(configShowSpawnPointsOneTime, Tag.SpawnPointOneTime);
      configShowSpawnPointsRespawning = config.Bind(section, "Spawn points (respawning)", 1, CreateDescription());
      OnChanged(configShowSpawnPointsRespawning, Tag.SpawnPointRespawning);
      configShowSpawnerRays = config.Bind(section, "Creature spawner rays", 1, CreateDescription());
      OnChanged(configShowSpawnerRays, Tag.SpawnerRay);
      configShowSpawnerTriggerRanges = config.Bind(section, "Creature spawner trigger ranges", 1, CreateDescription());
      OnChanged(configShowSpawnerRays, Tag.SpawnerTriggerRange);
      configShowSpawnerLimitRanges = config.Bind(section, "Creature spawner limit ranges", 1, CreateDescription());
      OnChanged(configShowSpawnerRays, Tag.SpawnerLimitRange);
      configShowSpawnerSpawnRanges = config.Bind(section, "Creature spawner spawn ranges", 1, CreateDescription());
      OnChanged(configShowSpawnerRays, Tag.SpawnerSpawnRange);
      configShowSpawnZones = config.Bind(section, "Spawn zones", 1, CreateDescription());
      OnChanged(configShowSpawnZones, Tag.SpawnZoneAshlands);
      OnChanged(configShowSpawnZones, Tag.SpawnZoneBlackForest);
      OnChanged(configShowSpawnZones, Tag.SpawnZoneDeepNorth);
      OnChanged(configShowSpawnZones, Tag.SpawnZoneMeadows);
      OnChanged(configShowSpawnZones, Tag.SpawnZoneMistlands);
      OnChanged(configShowSpawnZones, Tag.SpawnZoneMountain);
      OnChanged(configShowSpawnZones, Tag.SpawnZoneOcean);
      OnChanged(configShowSpawnZones, Tag.SpawnZonePlains);
      OnChanged(configShowSpawnZones, Tag.SpawnZoneSwamp);
      OnChanged(configShowSpawnZones, Tag.SpawnZoneUnknown);
      configShowZoneCorners = config.Bind(section, "Zone corner rays", 1, CreateDescription());
      OnChanged(configShowZoneCorners, Tag.ZoneCornerAshlands);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerBlackForest);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerDeepNorth);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerMeadows);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerMistlands);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerMountain);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerOcean);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerPlains);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerSwamp);
      OnChanged(configShowZoneCorners, Tag.ZoneCornerUnknown);
      configShowRandomEventSystem = config.Bind(section, "Random event system", 1, CreateDescription());
      OnChanged(configShowRandomEventSystem, Tag.RandomEventSystem);
      configShowEffectAreasBurning = config.Bind(section, "Area effects: Burning", 1, CreateDescription());
      OnChanged(configShowEffectAreasBurning, Tag.EffectAreaBurning);
      configShowEffectAreasComfort = config.Bind(section, "Area effects: Comfort", 1, CreateDescription());
      OnChanged(configShowEffectAreasComfort, Tag.EffectAreaComfort);
      configShowEffectAreasCustomContainer = config.Bind(section, "Area effects: Custom container", -1, CreateDescription());
      OnChanged(configShowEffectAreasCustomContainer, Tag.EffectAreaCustomContainer);
      configShowEffectAreasCustomCrafting = config.Bind(section, "Area effects: Custom crafting", -1, CreateDescription());
      OnChanged(configShowEffectAreasCustomCrafting, Tag.EffectAreaCustomCrafting);
      configShowEffectAreasFire = config.Bind(section, "Area effects: Fire", 1, CreateDescription());
      OnChanged(configShowEffectAreasFire, Tag.EffectAreaFire);
      configShowEffectAreasHeat = config.Bind(section, "Area effects: Heat", 1, CreateDescription());
      OnChanged(configShowEffectAreasHeat, Tag.EffectAreaHeat);
      configShowEffectAreasNoMonsters = config.Bind(section, "Area effects: No monsters", 1, CreateDescription());
      OnChanged(configShowEffectAreasNoMonsters, Tag.EffectAreaNoMonsters);
      configShowEffectAreasOther = config.Bind(section, "Area effects: Other", -1, CreateDescription());
      OnChanged(configShowEffectAreasOther, Tag.EffectAreaOther);
      configShowEffectAreasPlayerBase = config.Bind(section, "Area effects: Player base", 1, CreateDescription());
      OnChanged(configShowEffectAreasPlayerBase, Tag.EffectAreaPlayerBase);
      configShowEffectAreasWarmCozy = config.Bind(section, "Area effects: Warm cozy", 1, CreateDescription());
      OnChanged(configShowEffectAreasWarmCozy, Tag.EffectAreaWarmCozy);
      configShowEffectAreasPrivateArea = config.Bind(section, "Area effects: Private area", 1, CreateDescription());
      OnChanged(configShowEffectAreasPrivateArea, Tag.EffectAreaPrivateArea);
      configShowEffectAreasTeleport = config.Bind(section, "Area effects: Teleport", 1, CreateDescription());
      OnChanged(configShowEffectAreasTeleport, Tag.EffectAreaTeleport);
      configShowSmoke = config.Bind(section, "Smoke", 1, CreateDescription());
      OnChanged(configShowSmoke, Tag.Smoke);
      configShowPlayerCover = config.Bind(section, "Player cover", 0, CreateDescription());
      OnChanged(configShowPlayerCover, Tag.PlayerCover);
      OnChanged(configShowPlayerCover, Tag.PlayerCoverBlocked);
    }
  }
}
