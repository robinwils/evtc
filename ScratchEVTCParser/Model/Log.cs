using System.Collections.Generic;
using System.Linq;
using ScratchEVTCParser.Events;
using ScratchEVTCParser.Model.Agents;
using ScratchEVTCParser.Model.Skills;
using ScratchEVTCParser.Statistics.Encounters;

namespace ScratchEVTCParser.Model
{
	public class Log
	{
		private readonly Event[] events;
		private readonly Agent[] agents;
		private readonly Skill[] skills;

		public IEnumerable<Event> Events => events;
		public IEnumerable<Agent> Agents => agents;
		public IEnumerable<Skill> Skills => skills;

		public string EVTCVersion { get; }

		public LogTime StartTime { get; }
		public LogTime EndTime { get; }

		public Agent MainTarget { get; }
		public Player PointOfView { get; }
		public int? Language { get; }
		public int? GameBuild { get; }
		public int? GameShardId { get; }

		public Log(Agent mainTarget, IEnumerable<Event> events, IEnumerable<Agent> agents,
			IEnumerable<Skill> skills, string evtcVersion, LogTime startTime, LogTime endTime, Player pointOfView,
			int? language, int? gameBuild, int? gameShardId)
		{
			MainTarget = mainTarget;
			EVTCVersion = evtcVersion;
			StartTime = startTime;
			EndTime = endTime;
			PointOfView = pointOfView;
			Language = language;
			GameBuild = gameBuild;
			GameShardId = gameShardId;
			this.events = events as Event[] ?? events.ToArray();
			this.agents = agents as Agent[] ?? agents.ToArray();
			this.skills = skills as Skill[] ?? skills.ToArray();
		}

	}
}