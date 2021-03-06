﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using jsreport.AspNetCore;
using jsreport.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCVTry.Models;

namespace PCVTry.Controllers
{
    public class UserController : Controller
    {
        private readonly MVCContext _context;

        public UserController(MVCContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }





        // GET: User/Create
        public IActionResult RequestInfoesCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RequestInfoesCreate([Bind("TodayDate,RequestType,RequestByName,EffectiveStart,EffectiveEnd,RequestId")] Requestinfo requestinfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestinfo);
                await _context.SaveChangesAsync();
                return RedirectToAction("UserTablesCreate", "User");
            }
            return View(requestinfo);
        }
        // GET: UserTables/Create
        public IActionResult UserTablesCreate()
        {
            return View();
        }

        // POST: UserTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserTablesCreate([Bind("UserId,LastName,FirstName,Department,Office,ManagerName,IsManager,DateStart,DateEnd")] UserTable userTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userTable);
                await _context.SaveChangesAsync();
                return RedirectToAction("UserRequirementsCreate","User");
            }
            return View(userTable);
        }
        public IActionResult UserRequirementsCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserRequirementsCreate([Bind("UserReqId,FloorNum,CubeNum,DidNum,DualMon,RemoAcc,RemoLap,Mobile,UserStatus,UserName")] UserRequirements userRequirements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRequirements);
                await _context.SaveChangesAsync();
                return RedirectToAction("VmsRolegroupsCreate", "User");
            }
            return View(userRequirements);
        }

        public IActionResult VmsRolegroupsCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VmsRolegroupsCreate([Bind("VmsroleGroupId,AccountGroup,AdminSupport,Assignor,Auditor,CliServiDeptMgr,CliServiGroup,CommercialGroup,ContractorQc,Itgroup,ProcessingShippingGroup,QcsupervisorLead,Qc,SalesGroup,StatusGroup,VendorRelationsGroup")] VmsRolegroup vmsRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vmsRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction("OtsAccessCreate", "User");
            }
            return View(vmsRolegroup);
        }
        public IActionResult AddiAccessCreate()
        {
            return View();
        }

        // POST: AddiAccesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddiAccessCreate([Bind("AddiAccessId,Pci,Fdic,Crm,CopyOf")] AddiAccess addiAccess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addiAccess);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addiAccess);
        }
        public IActionResult OtsAccessCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OtsAccessCreate([Bind("OtsAccessId,Return,MultiAssign,DeleteOrder,ToReassign,RecreateOrder,AppraisalTagShip,MaintainTagReasons,MaintainClariReasons,AuditAdmin,DisputeQueueAccess")] OtsAccess otsAccess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(otsAccess);
                await _context.SaveChangesAsync();
                return RedirectToAction("BpoRoleGroupsCreate", "User");
            }
            return View(otsAccess);
        }
        public IActionResult BpoRoleGroupsCreate()
        {
            return View();
        }

        // POST: BpoRolegroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BpoRoleGroupsCreate([Bind("Bpoid,Bpoadmin,ContractQc,FdicQc,HoldOrders,MarkOrdersShipped,QcBasic,QcPlus,QcSupervisor,ViewRules")] BpoRolegroup bpoRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bpoRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction("LrvRoleGroupCreate", "User");
            }
            return View(bpoRolegroup);
        }
        public IActionResult LrvRoleGroupCreate()
        {
            return View();
        }

        // POST: LrvRolegroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LrvRoleGroupCreate([Bind("LrvId,LrvAdmin,FannieQc,RegularQc,AllQueues")] LrvRolegroup lrvRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lrvRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction("Invoice", "User");
            }
            return View(lrvRolegroup);
        }

   

    }
}