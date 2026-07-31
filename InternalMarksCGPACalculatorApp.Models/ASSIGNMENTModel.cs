namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 4:52:20 PM
			public class ASSIGNMENTModel
			{

			 public System.Guid ?ASSIGNMENTid	{ get; set; }

[xssFilter]
public string assignmentno{ get; set; }

[xssFilter]
public string assignmentname{ get; set; }

[DataType(DataType.Date)][ModelBinder(BinderType = typeof(DateTimeModelBinder))][DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]public DateTime duedate	{ get; set; }

[xssFilter]
public string assignmentstatus{ get; set; }

public int? marksobtain{ get; set; }
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
			

			public class ASSIGNMENTModelValidator: AbstractValidator<ASSIGNMENTModel>
			{
					 
					public ASSIGNMENTModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_ASSIGNMENT", () =>
                                    {
                                        {RuleFor(m => m.assignmentno)
.MaximumLength(256).WithMessage("The allowed length of Assignment no is 256 characters or fewer")
;
RuleFor(m => m.assignmentname)
.NotEmpty().WithMessage("Assignment Name is required")
.MaximumLength(128).WithMessage("The allowed length of Assignment Name is 128 characters or fewer")
;
RuleFor(m => m.duedate)
.NotEmpty().WithMessage("Due Date is required")


;
RuleFor(m => m.assignmentstatus)
.NotEmpty().WithMessage("Assignment Status is required")
;
RuleFor(m => m.marksobtain)
.LessThanOrEqualTo(40).WithMessage("Marks obtain should be LessThanOrEqualTo 40")

;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_ASSIGNMENT", () =>
                                    {
                                        {RuleFor(m => m.assignmentno)
.MaximumLength(256).WithMessage("The allowed length of Assignment no is 256 characters or fewer")
;
RuleFor(m => m.assignmentname)
.NotEmpty().WithMessage("Assignment Name is required")
.MaximumLength(128).WithMessage("The allowed length of Assignment Name is 128 characters or fewer")
;
RuleFor(m => m.duedate)
.NotEmpty().WithMessage("Due Date is required")


;
RuleFor(m => m.assignmentstatus)
.NotEmpty().WithMessage("Assignment Status is required")
;
RuleFor(m => m.marksobtain)
.LessThanOrEqualTo(40).WithMessage("Marks obtain should be LessThanOrEqualTo 40")

;
}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
