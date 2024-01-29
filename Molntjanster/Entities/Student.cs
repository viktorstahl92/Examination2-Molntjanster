using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molntjanster.Entities
{
    public class Student : BaseEntity
    {
        /// <summary>
        /// The name of the student.
        /// </summary>
        public string StudentName { get; set; } = null!;

        /// <summary>
        /// The email of the student.
        /// </summary>
        public string Email { get; set; } = null!;

    }
}
