namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/31/2026 9:49:26 AM
			public class INTERNALASSESSMENTModel
			{

			 public System.Guid ?INTERNALASSESSMENTid	{ get; set; }

[xssFilter]
public string assessmentid{ get; set; }

[xssFilter]
public string studentid{ get; set; }

public Guid? subjectcode	{ get; set; }

[xssFilter]
public string? coursecode{ get; set; }

[xssFilter]
public string internals{ get; set; }

public int? maxmarks{ get; set; }

public int? marksobtained{ get; set; }
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
			

			public class INTERNALASSESSMENTModelValidator: AbstractValidator<INTERNALASSESSMENTModel>
			{
					 
					public INTERNALASSESSMENTModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Internal_Assessment", () =>
                                    {
                                        {RuleFor(m => m.assessmentid)
.MaximumLength(256).WithMessage("The allowed length of Assessment ID is 256 characters or fewer")
;
RuleFor(m => m.studentid)
.NotEmpty().WithMessage("Student ID is required")
;


RuleFor(m => m.internals)
.NotEmpty().WithMessage("INTERNALS is required")
;
RuleFor(m => m.maxmarks)
.LessThanOrEqualTo(60).WithMessage("Max marks should be LessThanOrEqualTo 60")

;
RuleFor(m => m.marksobtained)
.LessThanOrEqualTo(60).WithMessage("Marks obtained should be LessThanOrEqualTo 60")

;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Internal_Assessment", () =>
                                    {
                                        {RuleFor(m => m.assessmentid)
.MaximumLength(256).WithMessage("The allowed length of Assessment ID is 256 characters or fewer")
;
RuleFor(m => m.studentid)
.NotEmpty().WithMessage("Student ID is required")
;


RuleFor(m => m.internals)
.NotEmpty().WithMessage("INTERNALS is required")
;
RuleFor(m => m.maxmarks)
.LessThanOrEqualTo(60).WithMessage("Max marks should be LessThanOrEqualTo 60")

;
RuleFor(m => m.marksobtained)
.LessThanOrEqualTo(60).WithMessage("Marks obtained should be LessThanOrEqualTo 60")

;
}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
