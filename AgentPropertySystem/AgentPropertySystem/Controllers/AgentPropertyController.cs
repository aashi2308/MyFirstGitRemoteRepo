using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AgentPropertySystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgentPropertySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentPropertyController : ControllerBase
    {
        private readonly AgentPropertyDbContext _context;
        private readonly HTTPResponseManager _hTTPResponseManager;
        public AgentPropertyController(AgentPropertyDbContext context, HTTPResponseManager hTTPResponseManager)
        {
            _context = context;
            _hTTPResponseManager = hTTPResponseManager;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpPost("addproperty")]
        public async Task <IActionResult> AddPropertyDetails([FromBody]PropertyDetail propertyDetail)
        {
            try
            {
                if (propertyDetail == null)

                {
                    return _hTTPResponseManager.ReturnHTTPResponse("Model Class can not be null, please check your request body", HttpStatusCode.BadRequest);
                }
                if (!ModelState.IsValid)
                {
                    string modelErrorMessage = string.Join(" | ", ModelState.Values
                      .SelectMany(v => v.Errors)
                      .Select(e => e.ErrorMessage));
                    return _hTTPResponseManager.ReturnHTTPResponse(modelErrorMessage, HttpStatusCode.BadRequest);

                }
                await _context.PropertyDetails.AddAsync(propertyDetail);
                await _context.SaveChangesAsync();

                return _hTTPResponseManager.ReturnHTTPResponse("Added successfully", HttpStatusCode.OK);
            }
            
            catch (Exception ex)
            {
                return _hTTPResponseManager.ReturnHTTPResponse("Failed because: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost("addagent")]
        public async Task<IActionResult> AddAgentDetails([FromBody]AgentDetail agentDetail)
        {
            try
            {
                if (agentDetail == null)

                {
                    return _hTTPResponseManager.ReturnHTTPResponse("Model Class can not be null, please check your request body", HttpStatusCode.BadRequest);
                }
                if (!ModelState.IsValid)
                {
                    string modelErrorMessage = string.Join(" | ", ModelState.Values
              .SelectMany(v => v.Errors)
              .Select(e => e.ErrorMessage));
                    return _hTTPResponseManager.ReturnHTTPResponse(modelErrorMessage, HttpStatusCode.BadRequest);

                }
                await _context.AgentDetails.AddAsync(agentDetail);
                await _context.SaveChangesAsync();

                return _hTTPResponseManager.ReturnHTTPResponse("Added successfully", HttpStatusCode.OK);
            }

            catch (Exception ex)
            {
                return _hTTPResponseManager.ReturnHTTPResponse("Failed because: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet("property")]
        public async Task<List<PropertyDetail>> PropertyDetails()
        {
            try
            {
                List<PropertyDetail> listOfProperty =  _context.Set<PropertyDetail>().ToList();
                return listOfProperty;
            }
            catch
            {
                throw;
            }
        }

    }
}