namespace InternalMarksCGPACalculatorAppWebApi.Controllers
			{
				using System;
				using System.Data;
				using System.Linq;
                using Newtonsoft.Json.Linq;
				using Microsoft.AspNetCore.Mvc;
				using System.Collections.Generic;
				using Microsoft.Extensions.Options;
				using Microsoft.Extensions.Logging;
				using Microsoft.AspNetCore.Authorization;
				using Microsoft.Extensions.Configuration;
				using System.IdentityModel.Tokens.Jwt;
				using System.Security.Claims;
				using System.Text;
				using Microsoft.IdentityModel.Tokens;
				using InternalMarksCGPACalculatorApp.Models;
				using InternalMarksCGPACalculatorApp.DAL;
				using FluentValidation.Results;

				using Microsoft.AspNetCore.Hosting;
				using System.IO;
				using System.Net.Http.Headers;
                using Microsoft.AspNetCore.Http;
                using Newtonsoft.Json;
                using System.Threading.Tasks;
				[Route("api/[controller]/[action]")]
				//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 4:57:27 PM
				public class EXAMSCHEDULEController : BaseController
				{
				    public EXAMSCHEDULEController(IHttpContextAccessor httpContextAccessor,IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				    {
					     _configuration = configuration;
					     _logger = loggerFactory.CreateLogger<EXAMSCHEDULEController>();
					     _connectionSettings = connectionSettings;
					     objEXAMSCHEDULEDAL = new EXAMSCHEDULEDAL(_connectionSettings.Value.ConnectionString);
                         obj_External_System_DAL =new External_System_DAL(_connectionSettings.Value.ConnectionString);
                         objExternalSystemUtitlity = new ExternalSystemUtility(_connectionSettings, _configuration);
					     hostingEnv = hostingEnvironment;

                            var authHeader = httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

                            if (authHeader.StartsWith("Bearer "))
                            {
                                   var token = authHeader.Substring("Bearer ".Length);
                                   string usersid = obj_External_System_DAL.get_users_info_by_token(token);
                                   string tenantid = string.IsNullOrEmpty(httpContextAccessor.HttpContext.Request.Query["tenantid"]) ? Guid.Empty.ToString(): httpContextAccessor.HttpContext.Request.Query["tenantid"].ToString();
                                   pvar_tenantid = usersid + "|" + tenantid;//usersid+tenantid
                                   pvar_usersid=usersid;

                            }
				    }
				private EXAMSCHEDULEDAL objEXAMSCHEDULEDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;
                private string pvar_tenantid="|";
                private string pvar_usersid="";

			    
            [HttpPost()]
            [ActionName("Add_EXAM_SCHEDULE")]
            public virtual IActionResult Add_EXAM_SCHEDULE([FromBody]EXAMSCHEDULEModel model)
            { 
              string message = "";
                
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_EXAM_SCHEDULE";
            try{

            if (ModelState.IsValid)
            {

            	EXAMSCHEDULEModelValidator validator = new EXAMSCHEDULEModelValidator();
            	ValidationResult results = validator.Validate(model);
            	if (!results.IsValid)
            	{
            		var errorCollection = string.Join(" | ", results.Errors.Select(e => e.ErrorMessage.Replace("{propertyName}",e.PropertyName)));
             		message = ("Validation Error : " + errorCollection);


            	}else{

                                   var authHeader = HttpContext.Request.Headers["Authorization"][0];
                                if (authHeader.StartsWith("Bearer "))
                                {
                                     
		                      
                                var token = authHeader.Substring("Bearer ".Length);
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
                                model.createduser=new Guid(userdetails[0].ToString());
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());

		       
                                 

                                
            		                
                                     message = objEXAMSCHEDULEDAL.Add_EXAM_SCHEDULE(model);
                               }
                                else{
                                  message = "Invalid Token";
                                 }

            	}


            }
            else
            {
            	var errorCollection = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
            	message = errorCollection.ToString();

            	_logger.LogError("EXAMSCHEDULEModel - Add_EXAM_SCHEDULE , Validation Error :" + message);
            	message = ("Validation Error : " + message);
            }






            }catch(Exception ex){
               message=ex.Message;
               _logger.LogError(ex,"An exception occurred in - Add_EXAM_SCHEDULE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
             
            }
            if(obj_access_logsdetailsModel.access_logsid !=null)
            {
                 obj_access_logsdetailsModel.api_response=message.Replace("\"",""); 
                 obj_External_System_DAL.create_access_logs_details(obj_access_logsdetailsModel);
            }

            if(message.Replace("\"","").Contains("201.1"))
                    return Ok(message);
                    else if(message.Replace("\"","")=="401.1")
                    return Unauthorized(message);
                    else
                    return BadRequest(message);


             }
[HttpGet()]
			  [ActionName("getById_EXAMSCHEDULE")]
			  public virtual EXAMSCHEDULEModel getById_EXAMSCHEDULE(string EXAMSCHEDULEid,string loginUserID="")
			  { 
				    EXAMSCHEDULEModel objEXAMSCHEDULE = new EXAMSCHEDULEModel();
					try
					{
						  objEXAMSCHEDULE = objEXAMSCHEDULEDAL.getById_EXAMSCHEDULE(EXAMSCHEDULEid);
					}
					catch (Exception ex)
					{
                         _logger.LogError(ex,"An exception occurred in - getById_EXAMSCHEDULE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
            
					}
					return objEXAMSCHEDULE;

			  }
			  [HttpPost()]
			  [ActionName("Update_EXAM_SCHEDULE")]
			  public virtual IActionResult Update_EXAM_SCHEDULE([FromBody]EXAMSCHEDULEModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_EXAM_SCHEDULE";

					try{

					if (ModelState.IsValid)
					{

						EXAMSCHEDULEModelValidator validator = new EXAMSCHEDULEModelValidator();
						ValidationResult results = validator.Validate(model);
						if (!results.IsValid)
						{
							var errorCollection = string.Join(" | ", results.Errors.Select(e => e.ErrorMessage.Replace("{propertyName}",e.PropertyName)));
							message = errorCollection.ToString();
							//return BadRequest("Validation Error : " + message);

						}else{
                            var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                       
                                 
		                      
                                var token = authHeader.Substring("Bearer ".Length);
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
                                model.modifieduser=new Guid(userdetails[0].ToString());
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());

		       
                                 
		       
                                	
							    message = objEXAMSCHEDULEDAL.Update_EXAM_SCHEDULE(model);	
                            }
                            else{
                                message = "Invalid Token";
                                 
                            }
							
						}


					}
					else
					{
						var errorCollection = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
						message = errorCollection.ToString();

						_logger.LogError("EXAMSCHEDULEModel - Update_EXAM_SCHEDULE, Validation Error :" + message);
					
						//return BadRequest("Validation Error : " + message);
					}






					}catch(Exception ex){
                        
						message=ex.Message;
					    _logger.LogError(ex,"An exception occurred in - Update_EXAM_SCHEDULE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
           
					}

                    if(obj_access_logsdetailsModel.access_logsid !=null)
                    {
                            obj_access_logsdetailsModel.api_response=message.Replace("\"",""); 
                            obj_External_System_DAL.create_access_logs_details(obj_access_logsdetailsModel);
                    }

					if(message.Replace("\"","")=="201.1")
					return Ok(message);
					else if(message.Replace("\"","")=="401.1")
					return Unauthorized(message);
					else
					return BadRequest(message);

					


			   }
[HttpGet()]
            public virtual string Remove_EXAM_SCHEDULE(string EXAMSCHEDULEid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_EXAM_SCHEDULE";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        
		                      
		                      
		                      var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		       
                                 
                        	 message = objEXAMSCHEDULEDAL.Remove_EXAM_SCHEDULE(EXAMSCHEDULEid,loginUserID);
						    }
	                        else{
		                        message = "Invalid Token";
		                       
	                        }
					 

					}catch(Exception ex){
						message=ex.Message;
                         _logger.LogError(ex,"An exception occurred in - Remove_EXAM_SCHEDULE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
                         
					}
                    if(obj_access_logsdetailsModel.access_logsid !=null)
                    {
                         obj_access_logsdetailsModel.api_response=message.Replace("\"",""); 
                         obj_External_System_DAL.create_access_logs_details(obj_access_logsdetailsModel);
                    }
                 
					return message;

			}
[HttpGet()]
			
			[ActionName("EXAM_SCHEDULE_List")]
			public virtual System.Data.DataTable EXAM_SCHEDULE_List()
			{
					 
				  	DataTable dtEXAMSCHEDULE = new DataTable();
					try
					{
                        
						dtEXAMSCHEDULE = objEXAMSCHEDULEDAL.EXAM_SCHEDULE_List();
					}
					catch (Exception ex)
					{
                         _logger.LogError(ex,"An exception occurred in - EXAM_SCHEDULE_List, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
                       
					}
					return dtEXAMSCHEDULE;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_EXAMSCHEDULE")]
			public virtual System.Data.DataTable get_all_EXAMSCHEDULE(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtEXAMSCHEDULE = new DataTable();
					try
					{
                        tenantid=pvar_tenantid;
						dtEXAMSCHEDULE = objEXAMSCHEDULEDAL.get_all_EXAMSCHEDULE(tenantid);
					}
					catch (Exception ex)
					{
                        _logger.LogError(ex,"An exception occurred in - get_all_EXAMSCHEDULE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
             
					   
					}
					return dtEXAMSCHEDULE;

			   }
[HttpGet()]
			  [ActionName("getById_allinfo_EXAMSCHEDULE")]
			  public virtual System.Data.DataTable getById_allinfo_EXAMSCHEDULE(string EXAMSCHEDULEid)
			  { 
				    DataTable dtEXAMSCHEDULE = new DataTable();
					try
					{
						  dtEXAMSCHEDULE = objEXAMSCHEDULEDAL.getById_allinfo_EXAMSCHEDULE(EXAMSCHEDULEid);
					}
					catch (Exception ex)
					{
                         _logger.LogError(ex,"An exception occurred in - getById_allinfo_EXAMSCHEDULE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
   
					}
					return dtEXAMSCHEDULE;

			  }






				}


			}
