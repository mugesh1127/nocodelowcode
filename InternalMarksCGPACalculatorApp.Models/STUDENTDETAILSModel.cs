namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 4:09:19 PM
			public class STUDENTDETAILSModel
			{

			 public System.Guid ?STUDENTDETAILSid	{ get; set; }

[xssFilter]
public string studentname{ get; set; }

[xssFilter]
public string rollnumber{ get; set; }

[xssFilter]
public string registernumber{ get; set; }

[xssFilter]
public string? admissionnumber{ get; set; }

[DataType(DataType.Date)][ModelBinder(BinderType = typeof(DateTimeModelBinder))][DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]public DateTime dateofbirth	{ get; set; }

[xssFilter]
public string department{ get; set; }

[xssFilter]
public string sec{ get; set; }

[xssFilter]
public string mobilenumber{ get; set; }

[xssFilter]
public string emailaddress{ get; set; }
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
			

			public class STUDENTDETAILSModelValidator: AbstractValidator<STUDENTDETAILSModel>
			{
					 
					public STUDENTDETAILSModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Student_Details", () =>
                                    {
                                        {RuleFor(m => m.studentname)
.NotEmpty().WithMessage("Student Name is required")
.MaximumLength(128).WithMessage("The allowed length of Student Name is 128 characters or fewer")
;
RuleFor(m => m.rollnumber)
.NotEmpty().WithMessage("Roll Number is required")
.MaximumLength(128).WithMessage("The allowed length of Roll Number is 128 characters or fewer")
;
RuleFor(m => m.registernumber)
.NotEmpty().WithMessage("Register Number is required")
.MaximumLength(128).WithMessage("The allowed length of Register Number is 128 characters or fewer")
;

RuleFor(m => m.dateofbirth)
.NotEmpty().WithMessage("Date of Birth is required")


;
RuleFor(m => m.department)
.NotEmpty().WithMessage("Department is required")
;
RuleFor(m => m.sec)
.NotEmpty().WithMessage("Sec is required")
;
RuleFor(m => m.mobilenumber)
.NotEmpty().WithMessage("Mobile Number is required")
.MaximumLength(20).WithMessage("The allowed length of Mobile Number is 20 characters or fewer ")

;
RuleFor(m => m.emailaddress)
.NotEmpty().WithMessage("Email Address is required")
.MaximumLength(128).WithMessage("The allowed length of Email Address is 128 characters or fewer")
.EmailAddress()

;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Student_Details", () =>
                                    {
                                        {RuleFor(m => m.studentname)
.NotEmpty().WithMessage("Student Name is required")
.MaximumLength(128).WithMessage("The allowed length of Student Name is 128 characters or fewer")
;
RuleFor(m => m.rollnumber)
.NotEmpty().WithMessage("Roll Number is required")
.MaximumLength(128).WithMessage("The allowed length of Roll Number is 128 characters or fewer")
;
RuleFor(m => m.registernumber)
.NotEmpty().WithMessage("Register Number is required")
.MaximumLength(128).WithMessage("The allowed length of Register Number is 128 characters or fewer")
;

RuleFor(m => m.dateofbirth)
.NotEmpty().WithMessage("Date of Birth is required")


;
RuleFor(m => m.department)
.NotEmpty().WithMessage("Department is required")
;
RuleFor(m => m.sec)
.NotEmpty().WithMessage("Sec is required")
;
RuleFor(m => m.mobilenumber)
.NotEmpty().WithMessage("Mobile Number is required")
.MaximumLength(20).WithMessage("The allowed length of Mobile Number is 20 characters or fewer ")

;
RuleFor(m => m.emailaddress)
.NotEmpty().WithMessage("Email Address is required")
.MaximumLength(128).WithMessage("The allowed length of Email Address is 128 characters or fewer")
.EmailAddress()

;
}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
