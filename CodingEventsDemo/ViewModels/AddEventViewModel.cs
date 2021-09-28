using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(500, ErrorMessage = "Location is too long!")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Number of attendees required")]
        [Range(0, 10000, ErrorMessage = "Number of attendees must be between 0 and 10,000")]
        public int NumOfAttendees { get; set; }

        public EventType Type { get; set; }

        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(EventType.Conference.ToString(), ((int)EventType.Conference).ToString()),
            new SelectListItem(EventType.Meetup.ToString(), ((int)EventType.Meetup).ToString()),
            new SelectListItem(EventType.Social.ToString(), ((int)EventType.Social).ToString()),
            new SelectListItem(EventType.Workshop.ToString(), ((int)EventType.Workshop).ToString())
        };

        [EmailAddress]
        public string ContactEmail { get; set; }


    }
}
