using System;

namespace HRMSAPP.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Department()
        {

        }
        public Department(int id, string name)
        {
            DepartmentId = id;
            DepartmentName = name;
        }

        public override string ToString()
        {
            return $"{DepartmentId},{DepartmentName}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new NullReferenceException($"null reference was passed to {nameof(this.Equals)} method");

            if (!(obj is Department))
                throw new ArgumentException($"{obj.GetType().Name} to {nameof(this.Equals)} method instaed of {this.GetType().Name} type");

            Department other = obj as Department;

            if (!this.DepartmentId.Equals(this.DepartmentId))
                return false;

            if (!this.DepartmentName.Equals(this.DepartmentName))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            const int prime = 23;
            return this.DepartmentId.GetHashCode() * prime;
        }
    }
}
