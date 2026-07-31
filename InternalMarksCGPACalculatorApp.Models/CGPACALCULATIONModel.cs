namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/31/2026 6:38:38 AM
			public class CGPACALCULATIONModel
			{

			 public System.Guid ?CGPACALCULATIONid	{ get; set; }

public int enternumberofsemesters{ get; set; }

public double entersgpa1{ get; set; }

public double? entersgpa2{ get; set; }

public double? entersgpa3{ get; set; }

public double? entersgpa4{ get; set; }

public double? entersgpa5{ get; set; }

public double? entersgpa6{ get; set; }

public double? entersgpa7{ get; set; }

public double? entersgpa8{ get; set; }

[xssFilter]
public string totalmarks{ get; set; }

[xssFilter]
public string cgpa{ get; set; }
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
			

			public class CGPACALCULATIONModelValidator: AbstractValidator<CGPACALCULATIONModel>
			{
					 
					public CGPACALCULATIONModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_CGPA_Calculation", () =>
                                    {
                                        {RuleFor(m => m.enternumberofsemesters)
.NotNull().WithMessage("ENTER NUMBER OF SEMESTERS is required")
.LessThanOrEqualTo(9).WithMessage("ENTER NUMBER OF SEMESTERS should be LessThanOrEqualTo 9")

;
RuleFor(m => m.entersgpa1)
.NotEmpty().WithMessage("Enter SGPA 1 is required")
;







RuleFor(m => m.totalmarks)
.NotEmpty().WithMessage("total marks is required")
.MaximumLength(256).WithMessage("The allowed length of total marks is 256 characters or fewer")
;
RuleFor(m => m.cgpa)
.NotEmpty().WithMessage("CGPA is required")
.MaximumLength(256).WithMessage("The allowed length of CGPA is 256 characters or fewer")
;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_CGPA_Calculation", () =>
                                    {
                                        {RuleFor(m => m.enternumberofsemesters)
.NotNull().WithMessage("ENTER NUMBER OF SEMESTERS is required")
.LessThanOrEqualTo(9).WithMessage("ENTER NUMBER OF SEMESTERS should be LessThanOrEqualTo 9")

;
RuleFor(m => m.entersgpa1)
.NotEmpty().WithMessage("Enter SGPA 1 is required")
;







RuleFor(m => m.totalmarks)
.NotEmpty().WithMessage("total marks is required")
.MaximumLength(256).WithMessage("The allowed length of total marks is 256 characters or fewer")
;
RuleFor(m => m.cgpa)
.NotEmpty().WithMessage("CGPA is required")
.MaximumLength(256).WithMessage("The allowed length of CGPA is 256 characters or fewer")
;
}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
