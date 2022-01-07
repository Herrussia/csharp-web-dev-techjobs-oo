using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
/*        private int id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }*/

/*        public CoreCompetency(string value) : base(value)
        {
            //Value = value;
        }*/

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                Id == competency.Id;
        }
/*
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }*/

        public override string ToString()
        {
            return Value;
        }
    }
}
