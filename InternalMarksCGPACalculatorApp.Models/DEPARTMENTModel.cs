namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 3:25:47 PM
			public class DEPARTMENTModel
			{

			 public System.Guid ?DEPARTMENTid	{ get; set; }

[xssFilter]
public string departmentname{ get; set; }

[xssFilter]
public string departmentcode{ get; set; }

[xssFilter]
public string hodname{ get; set; }

[xssFilter]
public string hodemail{ get; set; }

[xssFilter]
public string academyyear{ get; set; }
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
			

			public class DEPARTMENTModelValidator: AbstractValidator<DEPARTMENTModel>
			{
					 
					public DEPARTMENTModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Department", () =>
                                    {
                                        {RuleFor(m => m.departmentname)
.NotEmpty().WithMessage("Department Name is required")
.MaximumLength(128).WithMessage("The allowed length of Department Name is 128 characters or fewer")
;
RuleFor(m => m.departmentcode)
.NotEmpty().WithMessage("Department Code is required")
.MaximumLength(128).WithMessage("The allowed length of Department Code is 128 characters or fewer")
;
RuleFor(m => m.hodname)
.NotEmpty().WithMessage("HOD Name  is required")
.MaximumLength(128).WithMessage("The allowed length of HOD Name  is 128 characters or fewer")
;
RuleFor(m => m.hodemail)
.NotEmpty().WithMessage("HOD Email is required")
.MaximumLength(128).WithMessage("The allowed length of HOD Email is 128 characters or fewer")
.EmailAddress()

;
RuleFor(m => m.academyyear)
.NotEmpty().WithMessage("Academy Year  is required")
.MaximumLength(128).WithMessage("The allowed length of Academy Year  is 128 characters or fewer")
;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Department", () =>
                                    {
                                        {RuleFor(m => m.departmentname)
.NotEmpty().WithMessage("Department Name is required")
.MaximumLength(128).WithMessage("The allowed length of Department Name is 128 characters or fewer")
;
RuleFor(m => m.departmentcode)
.NotEmpty().WithMessage("Department Code is required")
.MaximumLength(128).WithMessage("The allowed length of Department Code is 128 characters or fewer")
;
RuleFor(m => m.hodname)
.NotEmpty().WithMessage("HOD Name  is required")
.MaximumLength(128).WithMessage("The allowed length of HOD Name  is 128 characters or fewer")
;
RuleFor(m => m.hodemail)
.NotEmpty().WithMessage("HOD Email is required")
.MaximumLength(128).WithMessage("The allowed length of HOD Email is 128 characters or fewer")
.EmailAddress()

;
RuleFor(m => m.academyyear)
.NotEmpty().WithMessage("Academy Year  is required")
.MaximumLength(128).WithMessage("The allowed length of Academy Year  is 128 characters or fewer")
;
}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
