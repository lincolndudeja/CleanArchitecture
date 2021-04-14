using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CleanArchitectureAPI.Enums
{
    public enum Departments
    {
        [EnumMember(Value = "Admin")] 
        Admin,
        [EnumMember(Value = "IT")]
        IT,
        [EnumMember(Value = "Accounts")]
        Accounts,
        [EnumMember(Value = "Advisory")]
        Advisory
    }
}
