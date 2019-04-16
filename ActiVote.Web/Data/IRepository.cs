using System.Collections.Generic;
using System.Threading.Tasks;
using ActiVote.Web.Data.Entities;

namespace ActiVote.Web.Data
{
    public interface IRepository
    {
        void AddCandidate(Candidate Candidate);

        void AddEvent(Event @event);

        bool CandidateExists(int id);

        bool EventExists(int id);

        Candidate GetCandidate(int id);

        IEnumerable<Candidate> GetCandidates();

        Event GetEvent(int id);

        IEnumerable<Event> GetEvents();

        void RemoveCandidate(Candidate Candidate);

        void RemoveEvent(Event @event);

        Task<bool> SaveAllAsync();

        void UpdateCandidate(Candidate Candidate);

        void UpdateEvent(Event @event);

    }
}