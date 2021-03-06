using System;
using System.Collections.Generic;

namespace ResumeGenerator.Model
{
    public class Experience
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public ExperienceType Type { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public List<string> Highlights { get; set; }

        public Link Link { get; set; }
    }
}