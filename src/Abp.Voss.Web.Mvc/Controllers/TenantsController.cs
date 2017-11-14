﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Voss.Authorization;
using Abp.Voss.Controllers;
using Abp.Voss.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace Abp.Voss.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : VossControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _tenantAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue }); //Paging not implemented yet
            return View(output);
        }

        public async Task<ActionResult> EditTenantModal(int tenantId)
        {
            var tenantDto = await _tenantAppService.Get(new EntityDto(tenantId));
            return View("_EditTenantModal", tenantDto);
        }
    }
}