﻿using CountyRP.Services.Site.Converters;
using CountyRP.Services.Site.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CountyRP.Services.Site.Repositories
{
    public partial class SiteRepository
    {
        public async Task<UserDtoOut> AddUserAsync(UserDtoIn userDtoIn)
        {
            var userDao = UserDtoInConverter.ToDb(userDtoIn);

            await _siteDbContext.Users.AddAsync(userDao);
            await _siteDbContext.SaveChangesAsync();

            return UserDaoConverter.ToRepository(userDao);
        }

        public async Task<UserDtoOut> GetUserByIdAsync(int id)
        {
            var userDao = await _siteDbContext
                .Users
                .AsNoTracking()
                .FirstOrDefaultAsync(users => users.Id == id);

            return (userDao != null) 
                ? UserDaoConverter.ToRepository(userDao)
                : null;
        }

        public async Task<UserDtoOut> GetUserByLoginAsync(string login)
        {
            var userDao = await _siteDbContext
                .Users
                .AsNoTracking()
                .FirstOrDefaultAsync(users => users.Login == login);

            return (userDao != null)
                ? UserDaoConverter.ToRepository(userDao)
                : null;
        }

        public async Task<UserDtoOut> UpdateUserAsync(int id, UserDtoIn userDtoIn)
        {
            var userDao = UserDtoInConverter.ToDb(id, userDtoIn);

            userDao = _siteDbContext.Users.Update(userDao)?.Entity;
            await _siteDbContext.SaveChangesAsync();

            return (userDao != null)
                ? UserDaoConverter.ToRepository(userDao)
                : null;
        }

        public async Task<PagedFilterResult<UserDtoOut>> GetUsersByFilterAsync(UserFilterDtoIn filter)
        {
            var usersQuery = _siteDbContext
                .Users
                .Where(
                    users =>
                        filter.Login != null && users.Login.Contains(filter.Login) &&
                        filter.GroupIds != null && filter.GroupIds.Contains(users.GroupId)
                )
                .AsQueryable();

            var allCount = await usersQuery.CountAsync();
            var maxPages = allCount / filter.Count;

            var filteredUsersDao = await usersQuery
                .Skip(filter.Count * (filter.Page - 1))
                .Take(filter.Count)
                .ToListAsync();

            return new PagedFilterResult<UserDtoOut>(
                allCount: allCount,
                maxPages: maxPages,
                items: filteredUsersDao
                    .Select(UserDaoConverter.ToRepository)
            );
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _siteDbContext
                .Users
                .FindAsync(id);

            _siteDbContext.Users.Remove(user);
            await _siteDbContext.SaveChangesAsync();
        }
    }
}
