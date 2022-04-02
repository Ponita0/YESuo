using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YESuo.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AdditionalProp1
    {
    }

    public class Action
    {
        public int actorCellId { get; set; }
        public int championId { get; set; }
        public bool completed { get; set; }
        public int id { get; set; }
        public bool isAllyAction { get; set; }
        public bool isInProgress { get; set; }
        public int pickTurn { get; set; }
        public string type { get; set; }
    }

    public class Bans
    {
        public List<int> myTeamBans { get; set; }
        public int numBans { get; set; }
        public List<int> theirTeamBans { get; set; }
    }

    public class ChatDetails
    {
        public string chatRoomName { get; set; }
        public string chatRoomPassword { get; set; }
    }

    public class EntitledFeatureState
    {
        public int additionalRerolls { get; set; }
        public List<int> unlockedSkinIds { get; set; }
    }

    public class MyTeam
    {
        public string assignedPosition { get; set; }
        public int cellId { get; set; }
        public int championId { get; set; }
        public int championPickIntent { get; set; }
        public string entitledFeatureType { get; set; }
        public int selectedSkinId { get; set; }
        public int spell1Id { get; set; }
        public int spell2Id { get; set; }
        public int summonerId { get; set; }
        public int team { get; set; }
        public int wardSkinId { get; set; }
    }

    public class TheirTeam
    {
        public string assignedPosition { get; set; }
        public int cellId { get; set; }
        public int championId { get; set; }
        public int championPickIntent { get; set; }
        public string entitledFeatureType { get; set; }
        public int selectedSkinId { get; set; }
        public int spell1Id { get; set; }
        public int spell2Id { get; set; }
        public int summonerId { get; set; }
        public int team { get; set; }
        public int wardSkinId { get; set; }
    }

    public class Timer
    {
        public int adjustedTimeLeftInPhase { get; set; }
        public long internalNowInEpochMs { get; set; }
        public bool isInfinite { get; set; }
        public string phase { get; set; }
        public int totalTimeInPhase { get; set; }
    }

    public class Trade
    {
        public int cellId { get; set; }
        public int id { get; set; }
        public string state { get; set; }
    }

    public class Root
    {
        public Action[][] actions { get; set; }
        public bool allowBattleBoost { get; set; }
        public bool allowDuplicatePicks { get; set; }
        public bool allowLockedEvents { get; set; }
        public bool allowRerolling { get; set; }
        public bool allowSkinSelection { get; set; }
        public Bans bans { get; set; }
        public List<int> benchChampionIds { get; set; }
        public bool benchEnabled { get; set; }
        public int boostableSkinCount { get; set; }
        public ChatDetails chatDetails { get; set; }
        public int counter { get; set; }
        public EntitledFeatureState entitledFeatureState { get; set; }
        public int gameId { get; set; }
        public bool hasSimultaneousBans { get; set; }
        public bool hasSimultaneousPicks { get; set; }
        public bool isCustomGame { get; set; }
        public bool isSpectating { get; set; }
        public int localPlayerCellId { get; set; }
        public int lockedEventIndex { get; set; }
        public List<MyTeam> myTeam { get; set; }
        public int recoveryCounter { get; set; }
        public int rerollsRemaining { get; set; }
        public bool skipChampionSelect { get; set; }
        public List<TheirTeam> theirTeam { get; set; }
        public Timer timer { get; set; }
        public List<Trade> trades { get; set; }
    }


}