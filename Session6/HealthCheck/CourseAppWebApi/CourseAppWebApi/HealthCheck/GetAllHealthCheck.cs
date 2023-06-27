using CourseAppWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CourseAppWebApi.HealthCheck
{
    public class GetAllHealthCheck : IHealthCheck
    {
        readonly AppDbContext _context;
        public GetAllHealthCheck(AppDbContext context)
        {
            _context=context;
        }
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                var list = await _context.Courses.ToListAsync();
               // throw new Exception("Error");
                return HealthCheckResult.Healthy();
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy(ex.Message);
            }
            
        }
    }
}
