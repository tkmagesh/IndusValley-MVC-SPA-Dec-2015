using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BugTrackerApp.Models;

namespace BugTrackerApp.Services
{
    public interface IBugService
    {
        IEnumerable<Bug> Bugs { get; }
        int Count { get; }
        void Add(Bug bug);
        void Add(string bugName);
    }

    public class BugService : IBugService
    {
        private static IList<Bug> bugs  = new List<Bug>();

        static BugService()
        {
            bugs.Add(new Bug() { Id = 1, Name = "Stack overflow error", IsClosed = false, CreatedAt = DateTime.Now });
            bugs.Add(new Bug()
            {
                Id = 2,
                Name = "User authentication failure",
                IsClosed = true,
                CreatedAt = DateTime.Now
            });
            bugs.Add(new Bug()
            {
                Id = 3,
                Name = "Server communication disrupted",
                IsClosed = false,
                CreatedAt = DateTime.Now
            });    
        }
        public IEnumerable<Bug> Bugs
        {
            get { return bugs; }
        }
        

        public void Add(Bug bug)
        {
            bugs.Add(bug);
        }

        public void Add(string bugName)
        {
            var newBug = new Bug()
            {
                Id = bugs.Max(b => b.Id) + 1,
                Name = bugName,
                IsClosed = false,
                CreatedAt = new DateTime()
            };
            bugs.Add(newBug);
        }

        public int Count
        {
            get { return bugs.Count; }
        }
    }
}