using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molntjanster.Entities
{
    public abstract class BaseEntity
    {
        /// <summary>
        ///     Surrogate key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Unique identifier
        /// </summary>
        public Guid Uid { get; set; } = Guid.NewGuid();

        /// <summary>
        ///     Timestamp of creation
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; } = DateTime.Now;
    }
}
