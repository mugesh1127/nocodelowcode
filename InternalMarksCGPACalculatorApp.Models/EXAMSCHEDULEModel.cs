namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 4:57:27 PM
			public class EXAMSCHEDULEModel
			{

			 public System.Guid ?EXAMSCHEDULEid	{ get; set; }

[xssFilter]
public string subjectname{ get; set; }

[xssFilter]
public string? examtype{ get; set; }

[DataType(DataType.Date)][ModelBinder(BinderType = typeof(DateTimeModelBinder))][DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]public DateTime examdate	{ get; set; }

[xssFilter]
public string starttime{ get; set; }

[xssFilter]
public string endtime{ get; set; }

[xssFilter]
public string? roomno{ get; set; }
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
			

			public class EXAMSCHEDULEModelValidator: AbstractValidator<EXAMSCHEDULEModel>
			{
					 
					public EXAMSCHEDULEModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_EXAM_SCHEDULE", () =>
                                    {
                                        {RuleFor(m => m.subjectname)
.NotEmpty().WithMessage("SUBJECT NAME is required")
.MaximumLength(128).WithMessage("The allowed length of SUBJECT NAME is 128 characters or fewer")
;

RuleFor(m => m.examdate)
.NotEmpty().WithMessage("Exam Date is required")


;
RuleFor(m => m.starttime)
.NotEmpty().WithMessage("Start Time is required")
;
RuleFor(m => m.endtime)
.NotEmpty().WithMessage("End Time is required")
;

}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_EXAM_SCHEDULE", () =>
                                    {
                                        {RuleFor(m => m.subjectname)
.NotEmpty().WithMessage("SUBJECT NAME is required")
.MaximumLength(128).WithMessage("The allowed length of SUBJECT NAME is 128 characters or fewer")
;

RuleFor(m => m.examdate)
.NotEmpty().WithMessage("Exam Date is required")


;
RuleFor(m => m.starttime)
.NotEmpty().WithMessage("Start Time is required")
;
RuleFor(m => m.endtime)
.NotEmpty().WithMessage("End Time is required")
;

}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
