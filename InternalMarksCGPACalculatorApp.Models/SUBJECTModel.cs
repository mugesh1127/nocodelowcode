namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 4:17:01 PM
			public class SUBJECTModel
			{

			 public System.Guid ?SUBJECTid	{ get; set; }

[xssFilter]
public string coursecode{ get; set; }

[xssFilter]
public string coursename{ get; set; }

public int credits{ get; set; }

[xssFilter]
public string semester{ get; set; }

[xssFilter]
public string department{ get; set; }

[xssFilter]
public string? facultyname{ get; set; }
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
			

			public class SUBJECTModelValidator: AbstractValidator<SUBJECTModel>
			{
					 
					public SUBJECTModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Subject", () =>
                                    {
                                        {RuleFor(m => m.coursecode)
.NotEmpty().WithMessage("Course Code is required")
.MaximumLength(128).WithMessage("The allowed length of Course Code is 128 characters or fewer")
;
RuleFor(m => m.coursename)
.NotEmpty().WithMessage("Course Name is required")
.MaximumLength(128).WithMessage("The allowed length of Course Name is 128 characters or fewer")
;
RuleFor(m => m.credits)
.NotNull().WithMessage("Credits is required")
.LessThanOrEqualTo(10).WithMessage("Credits should be LessThanOrEqualTo 10")

;
RuleFor(m => m.semester)
.NotEmpty().WithMessage("Semester is required")
;
RuleFor(m => m.department)
.NotEmpty().WithMessage("Department is required")
;

}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Subject", () =>
                                    {
                                        {RuleFor(m => m.coursecode)
.NotEmpty().WithMessage("Course Code is required")
.MaximumLength(128).WithMessage("The allowed length of Course Code is 128 characters or fewer")
;
RuleFor(m => m.coursename)
.NotEmpty().WithMessage("Course Name is required")
.MaximumLength(128).WithMessage("The allowed length of Course Name is 128 characters or fewer")
;
RuleFor(m => m.credits)
.NotNull().WithMessage("Credits is required")
.LessThanOrEqualTo(10).WithMessage("Credits should be LessThanOrEqualTo 10")

;
RuleFor(m => m.semester)
.NotEmpty().WithMessage("Semester is required")
;
RuleFor(m => m.department)
.NotEmpty().WithMessage("Department is required")
;

}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
