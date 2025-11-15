using System.Collections.Generic;

namespace HrApplication.Models
{
    public class repository
    {
        private static List<employeescshtml> employeeslist = new List<employeescshtml>();

        public static IEnumerable<employeescshtml> getemployees() => employeeslist;

        public static void addemployee(employeescshtml emp) => employeeslist.Add(emp);
    }
}
