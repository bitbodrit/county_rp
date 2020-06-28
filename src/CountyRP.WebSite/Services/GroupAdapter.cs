﻿using System.Linq;
using System.Threading.Tasks;

using CountyRP.Models;
using CountyRP.WebSite.Exceptions;
using CountyRP.WebSite.Models.ViewModels;
using CountyRP.WebSite.Services.Interfaces;

namespace CountyRP.WebSite.Services
{
    public class GroupAdapter : IGroupAdapter
    {
        private Extra.GroupClient _groupClient;

        public GroupAdapter(Extra.GroupClient groupClient)
        {
            _groupClient = groupClient;
        }

        public async Task<Group> Create(Group group)
        {
            var groupExt = new Extra.Group
            {
                Id = group.Id,
                Name = group.Name,
                Color = group.Color
            };

            try
            {
                groupExt = await _groupClient.CreateAsync(groupExt);
            }
            catch (Extra.ApiException<string> ex)
            {
                throw new AdapterException(ex.StatusCode, ex.Result);
            }

            return new Group
            {
                Id = groupExt.Id,
                Name = groupExt.Name,
                Color = groupExt.Color
            };
        }

        public async Task<Group> GetById(string id)
        {
            Extra.Group groupExt;

            try
            {
                groupExt = await _groupClient.GetByIdAsync(id);
            }
            catch (Extra.ApiException<string> ex)
            {
                throw new AdapterException(ex.StatusCode, ex.Result);
            }

            return new Group
            {
                Id = groupExt.Id,
                Name = groupExt.Name,
                Color = groupExt.Color
            };
        }

        public async Task<FilteredModels<Group>> FilterBy(int page, int count, string id, string name)
        {
            Extra.FilteredModelsOfGroup filteredGroupsExt;

            try
            {
                filteredGroupsExt = await _groupClient.FilterByAsync(page, count, id, name);
            }
            catch (Extra.ApiException<string> ex)
            {
                throw new AdapterException(ex.StatusCode, ex.Result);
            }

            return new FilteredModels<Group>
            {
                Items = filteredGroupsExt.Items.Select(g => new Group
                {
                    Id = g.Id,
                    Name = g.Name,
                    Color = g.Color
                }).ToList(),
                AllAmount = filteredGroupsExt.AllAmount,
                Page = filteredGroupsExt.Page,
                MaxPage = filteredGroupsExt.MaxPage
            };
        }

        public async Task<Group> Edit(string id, Group group)
        {
            var groupExt = new Extra.Group
            {
                Id = group.Id,
                Name = group.Name,
                Color = group.Color
            };

            try
            {
                groupExt = await _groupClient.EditAsync(id, groupExt);
            }
            catch (Extra.ApiException<string> ex)
            {
                throw new AdapterException(ex.StatusCode, ex.Result);
            }

            return new Group
            {
                Id = groupExt.Id,
                Name = groupExt.Name,
                Color = groupExt.Color
            };
        }

        public async Task Delete(string id)
        {
            try
            {
                await _groupClient.DeleteAsync(id);
            }
            catch (Extra.ApiException<string> ex)
            {
                throw new AdapterException(ex.StatusCode, ex.Result);
            }
        }
    }
}