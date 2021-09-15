﻿using CodingEventsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Data
{
    public class EventData
    {

        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //get ALL events:

        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //add events:
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        //remove an event:
        public static void Remove(int id)
        {
            Events.Remove(id);
        }

        //get by ID:
        public static Event GetById(int id)
        {
            return Events[id];
        }


    }
}
