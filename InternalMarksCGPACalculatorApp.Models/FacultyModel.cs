namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 3:40:47 PM
			public class FacultyModel
			{

			 public System.Guid ?Facultyid	{ get; set; }

[xssFilter]
public string facultyname{ get; set; }

[xssFilter]
public string designation{ get; set; }

[xssFilter]
public string department{ get; set; }

[xssFilter]
public string officialemail{ get; set; }

[xssFilter]
public string phonenumber{ get; set; }

public int experienceyear{ get; set; }
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
			

			public class FacultyModelValidator: AbstractValidator<FacultyModel>
			{
					 
					public FacultyModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Faculty", () =>
                                    {
                                        {RuleFor(m => m.facultyname)
.NotEmpty().WithMessage("Faculty Name is required")
.MaximumLength(128).WithMessage("The allowed length of Faculty Name is 128 characters or fewer")
;
RuleFor(m => m.designation)
.NotEmpty().WithMessage("Designation is required")
;
RuleFor(m => m.department)
.NotEmpty().WithMessage("Department is required")
;
RuleFor(m => m.officialemail)
.NotEmpty().WithMessage("Official Email is required")
.MaximumLength(128).WithMessage("The allowed length of Official Email is 128 characters or fewer")
.EmailAddress()

;
RuleFor(m => m.phonenumber)
.NotEmpty().WithMessage("Phone Number is required")
.MaximumLength(20).WithMessage("The allowed length of Phone Number is 20 characters or fewer ")

;
RuleFor(m => m.experienceyear)
.NotNull().WithMessage("Experience Years is required")
.LessThanOrEqualTo(99999999).WithMessage("Experience Years should be LessThanOrEqualTo 99999999")

;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Faculty", () =>
                                    {
                                        {RuleFor(m => m.facultyname)
.NotEmpty().WithMessage("Faculty Name is required")
.MaximumLength(128).WithMessage("The allowed length of Faculty Name is 128 characters or fewer")
;
RuleFor(m => m.designation)
.NotEmpty().WithMessage("Designation is required")
;
RuleFor(m => m.department)
.NotEmpty().WithMessage("Department is required")
;
RuleFor(m => m.officialemail)
.NotEmpty().WithMessage("Official Email is required")
.MaximumLength(128).WithMessage("The allowed length of Official Email is 128 characters or fewer")
.EmailAddress()

;
RuleFor(m => m.phonenumber)
.NotEmpty().WithMessage("Phone Number is required")
.MaximumLength(20).WithMessage("The allowed length of Phone Number is 20 characters or fewer ")

;
RuleFor(m => m.experienceyear)
.NotNull().WithMessage("Experience Years is required")
.LessThanOrEqualTo(99999999).WithMessage("Experience Years should be LessThanOrEqualTo 99999999")

;
}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
