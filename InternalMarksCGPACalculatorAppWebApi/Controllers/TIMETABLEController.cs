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
				//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 5:01:47 PM
				public class TIMETABLEController : BaseController
				{
				    public TIMETABLEController(IHttpContextAccessor httpContextAccessor,IOptions<ConnectionSettings> connectionSettings, ILoggerFactory loggerFactory, IConfiguration configuration,IWebHostEnvironment hostingEnvironment)
				    {
					     _configuration = configuration;
					     _logger = loggerFactory.CreateLogger<TIMETABLEController>();
					     _connectionSettings = connectionSettings;
					     objTIMETABLEDAL = new TIMETABLEDAL(_connectionSettings.Value.ConnectionString);
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
				private TIMETABLEDAL objTIMETABLEDAL;
                private External_System_DAL obj_External_System_DAL;
				private IOptions<ConnectionSettings> _connectionSettings;
				private ILogger _logger;
				private IConfiguration _configuration;
				private IWebHostEnvironment hostingEnv;
                private ExternalSystemUtility objExternalSystemUtitlity;
                private string pvar_tenantid="|";
                private string pvar_usersid="";

			    
            [HttpPost()]
            [ActionName("Add_TIME_TABLE")]
            public virtual IActionResult Add_TIME_TABLE([FromBody]TIMETABLEModel model)
            { 
              string message = "";
                
                access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Add_TIME_TABLE";
            try{

            if (ModelState.IsValid)
            {

            	TIMETABLEModelValidator validator = new TIMETABLEModelValidator();
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

		       
                                 

                                
            		                
                                     message = objTIMETABLEDAL.Add_TIME_TABLE(model);
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

            	_logger.LogError("TIMETABLEModel - Add_TIME_TABLE , Validation Error :" + message);
            	message = ("Validation Error : " + message);
            }






            }catch(Exception ex){
               message=ex.Message;
               _logger.LogError(ex,"An exception occurred in - Add_TIME_TABLE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
             
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
			  [ActionName("getById_TIMETABLE")]
			  public virtual TIMETABLEModel getById_TIMETABLE(string TIMETABLEid,string loginUserID="")
			  { 
				    TIMETABLEModel objTIMETABLE = new TIMETABLEModel();
					try
					{
						  objTIMETABLE = objTIMETABLEDAL.getById_TIMETABLE(TIMETABLEid);
					}
					catch (Exception ex)
					{
                         _logger.LogError(ex,"An exception occurred in - getById_TIMETABLE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
            
					}
					return objTIMETABLE;

			  }
			  [HttpPost()]
			  [ActionName("Update_TIME_TABLE")]
			  public virtual IActionResult Update_TIME_TABLE([FromBody]TIMETABLEModel model)
			  { 
				    string message = "";
                   access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Update_TIME_TABLE";

					try{

					if (ModelState.IsValid)
					{

						TIMETABLEModelValidator validator = new TIMETABLEModelValidator();
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

		       
                                 
		       
                                	
							    message = objTIMETABLEDAL.Update_TIME_TABLE(model);	
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

						_logger.LogError("TIMETABLEModel - Update_TIME_TABLE, Validation Error :" + message);
					
						//return BadRequest("Validation Error : " + message);
					}






					}catch(Exception ex){
                        
						message=ex.Message;
					    _logger.LogError(ex,"An exception occurred in - Update_TIME_TABLE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
           
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
            public virtual string Remove_TIME_TABLE(string TIMETABLEid,string loginUserID="")
			{
					string message ="";
                    access_logsdetailsModel obj_access_logsdetailsModel = new access_logsdetailsModel();
                   obj_access_logsdetailsModel.action_method_name="Remove_TIME_TABLE";

					try{
						
						  var authHeader = HttpContext.Request.Headers["Authorization"][0];
	                        if (authHeader.StartsWith("Bearer "))
	                        {
		                        
		                      
		                      
		                      var token = authHeader.Substring("Bearer ".Length);
		                         
		                        String[] userdetails=obj_External_System_DAL.get_users_by_token(token);
		                        loginUserID=userdetails[0].ToString();
                                obj_access_logsdetailsModel.access_logsid=new Guid(userdetails[1].ToString());
		       
                                 
                        	 message = objTIMETABLEDAL.Remove_TIME_TABLE(TIMETABLEid,loginUserID);
						    }
	                        else{
		                        message = "Invalid Token";
		                       
	                        }
					 

					}catch(Exception ex){
						message=ex.Message;
                         _logger.LogError(ex,"An exception occurred in - Remove_TIME_TABLE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
                         
					}
                    if(obj_access_logsdetailsModel.access_logsid !=null)
                    {
                         obj_access_logsdetailsModel.api_response=message.Replace("\"",""); 
                         obj_External_System_DAL.create_access_logs_details(obj_access_logsdetailsModel);
                    }
                 
					return message;

			}
[HttpGet()]
			
			[ActionName("TIME_TABLE_List")]
			public virtual System.Data.DataTable TIME_TABLE_List()
			{
					 
				  	DataTable dtTIMETABLE = new DataTable();
					try
					{
                        
						dtTIMETABLE = objTIMETABLEDAL.TIME_TABLE_List();
					}
					catch (Exception ex)
					{
                         _logger.LogError(ex,"An exception occurred in - TIME_TABLE_List, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
                       
					}
					return dtTIMETABLE;

			   }
			   
[HttpGet()]
			
			[ActionName("get_all_TIMETABLE")]
			public virtual System.Data.DataTable get_all_TIMETABLE(string tenantid,string loginUserID="")
			{
					 
				  	DataTable dtTIMETABLE = new DataTable();
					try
					{
                        tenantid=pvar_tenantid;
						dtTIMETABLE = objTIMETABLEDAL.get_all_TIMETABLE(tenantid);
					}
					catch (Exception ex)
					{
                        _logger.LogError(ex,"An exception occurred in - get_all_TIMETABLE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
             
					   
					}
					return dtTIMETABLE;

			   }
[HttpGet()]
			  [ActionName("getById_allinfo_TIMETABLE")]
			  public virtual System.Data.DataTable getById_allinfo_TIMETABLE(string TIMETABLEid)
			  { 
				    DataTable dtTIMETABLE = new DataTable();
					try
					{
						  dtTIMETABLE = objTIMETABLEDAL.getById_allinfo_TIMETABLE(TIMETABLEid);
					}
					catch (Exception ex)
					{
                         _logger.LogError(ex,"An exception occurred in - getById_allinfo_TIMETABLE, Error Message : " + (ex.StackTrace != null ? $", Stack Trace: {ex.StackTrace.ToString()}" :ex.Message));
   
					}
					return dtTIMETABLE;

			  }






				}


			}
