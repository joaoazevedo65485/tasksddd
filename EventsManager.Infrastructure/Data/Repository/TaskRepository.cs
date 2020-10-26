using EventsManager.Domain.Entity;
using EventsManager.Domain.Interfaces.Repository;

namespace EventsManager.Infrastructure.Data.Repository
{
    public class TaskRepository : BaseRepository<Task>, ITaskRepository
    {
        private readonly SqlContext sqlContext;

        public TaskRepository(SqlContext sqlContext) 
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
