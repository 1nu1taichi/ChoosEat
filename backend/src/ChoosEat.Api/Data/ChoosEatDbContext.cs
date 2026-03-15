using Microsoft.EntityFrameworkCore;

namespace ChoosEat.Api.Data;

public class ChoosEatDbContext(DbContextOptions<ChoosEatDbContext> options) : DbContext(options)
{
}
