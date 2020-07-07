using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ISectionRepository
    {
        IEnumerable<Section> GetSections(Guid courseId, bool trackChanges);
       Section GetSection(Guid courseId, Guid id, bool trackChanges);
    }
}
