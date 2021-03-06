using BMW_ONBOARDING_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMW_ONBOARDING_SYSTEM.Interfaces
{
    public interface ILessonContentRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        Task<LessonContent[]> GetLessonContentByLessonOutcomeIDsAsync(int id);
        //Task<LessonContent> GetCourseByNameAsync(string name);

        Task<LessonContent> GetLessonContentByIdAsync(int id);




    }
}
