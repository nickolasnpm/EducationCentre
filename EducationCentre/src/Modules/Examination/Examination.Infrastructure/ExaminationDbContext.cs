using Microsoft.EntityFrameworkCore;

namespace Examination.Infrastructure;

public sealed class ExaminationDbContext(DbContextOptions<ExaminationDbContext> options)
    : DbContext(options)
{
}
