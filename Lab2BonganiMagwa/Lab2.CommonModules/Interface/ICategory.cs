using Lab2.CommonModules.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.CommonModules.Interface
{
    public interface ICategory 
    {
        Task<bool> Add(Category category);
        Task<bool> Edit(Category category, int id);
    }
}
