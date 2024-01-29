using Molntjanster.Data;
using Molntjanster.UseCases.ManageStudents.Models;

namespace Molntjanster.UseCases.ManageStudents
{
    public class Read
    {
        public record GetStudentByStudentNameQuery(string studentName) : IRequest<List<StudentModel>>;

        public class GetStudentByStudentNameHandler : IRequestHandler<GetStudentByStudentNameQuery, List<StudentModel>>
        {
            private readonly MolntjansterContext _context;
            private readonly IConfigurationProvider _configurationProvider;

            public GetStudentByStudentNameHandler(MolntjansterContext context, IConfigurationProvider configurationProvider)
            {
                _context = context;
                _configurationProvider = configurationProvider;
            }

            public async Task<List<StudentModel>> Handle(GetStudentByStudentNameQuery request, CancellationToken cancellationToken)
            {
                return await _context.Students
                                    .ProjectTo<StudentModel>(_configurationProvider)
                                    .Where(st => (st.StudentName ?? "").ToUpper().Contains(request.studentName.ToUpper()))
                                    .ToListAsync(cancellationToken);
            }
        }
    }
}
