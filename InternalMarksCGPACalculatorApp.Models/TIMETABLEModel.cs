namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/31/2026 10:24:28 AM
			public class TIMETABLEModel
			{

			 public System.Guid ?TIMETABLEid	{ get; set; }

[xssFilter]
public string? course{ get; set; }

[xssFilter]
public string? faculty{ get; set; }

[xssFilter]
public string? dept{ get; set; }

[xssFilter]
public string? period{ get; set; }
public System.Guid ?createduser	{ get; set; }
[DataType(DataType.Date)]
[ModelBinder(BinderType = typeof(DateTimeModelBinder))]
[DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
public System.DateTime ?createddate	{ get; set; }
public System.Guid ?modifieduser	{ get; set; }
[DataType(DataType.Date)]
[ModelBinder(BinderType = typeof(DateTimeModelBinder))]
[DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
public System.DateTime ?modifieddate	{ get; set; }
public bool isdeleted	{ get; set; }
[xssFilter]
                        [Required(ErrorMessage = "craftmyapp_actionmethodname is required,please pass current action name")]
                        public String craftmyapp_actionmethodname{ get; set; }



			}
			

			public class TIMETABLEModelValidator: AbstractValidator<TIMETABLEModel>
			{
					 
					public TIMETABLEModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_TIME_TABLE", () =>
                                    {
                                        {



}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_TIME_TABLE", () =>
                                    {
                                        {



}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
