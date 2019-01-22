using System.Collections.Generic;
using ScratchEVTCParser.Events;
using ScratchEVTCParser.Model.Agents;
using ScratchEVTCParser.Statistics.Encounters.Phases;
using ScratchEVTCParser.Statistics.Encounters.Results;

namespace ScratchEVTCParser.Statistics.Encounters
{
	public class DefaultEncounter : BaseEncounter
	{
		public DefaultEncounter(Agent boss, IEnumerable<Event> events) : base(new[] {boss}, events,
			new PhaseSplitter(new StartTrigger(new PhaseDefinition("Default phase", new[] {boss}))),
			new AgentDeathResultDeterminer(boss),
			new AgentNameEncounterNameProvider(boss))
		{
		}
	}
}