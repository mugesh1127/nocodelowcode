namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 4:19:16 PM
			public class AttendanceModel
			{

			 public System.Guid ?Attendanceid	{ get; set; }

[DataType(DataType.Date)][ModelBinder(BinderType = typeof(DateTimeModelBinder))][DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]public DateTime attendancedate	{ get; set; }

[xssFilter]
public string checkintime{ get; set; }

[xssFilter]
public string? checkouttime{ get; set; }

[xssFilter]
public string status{ get; set; }

public decimal? attendancepercentage{ get; set; }
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
			

			public class AttendanceModelValidator: AbstractValidator<AttendanceModel>
			{
					 
					public AttendanceModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_Attendance", () =>
                                    {
                                        {RuleFor(m => m.attendancedate)
.NotEmpty().WithMessage("Attendance Date is required")


;
RuleFor(m => m.checkintime)
.NotEmpty().WithMessage("Checkin Time is required")
;

RuleFor(m => m.status)
.NotEmpty().WithMessage("Status is required")
;
RuleFor(m => m.attendancepercentage)
.LessThanOrEqualTo(100).WithMessage("Attendance Percentage should be LessThanOrEqualTo 100")

;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_Attendance", () =>
                                    {
                                        {RuleFor(m => m.attendancedate)
.NotEmpty().WithMessage("Attendance Date is required")


;
RuleFor(m => m.checkintime)
.NotEmpty().WithMessage("Checkin Time is required")
;

RuleFor(m => m.status)
.NotEmpty().WithMessage("Status is required")
;
RuleFor(m => m.attendancepercentage)
.LessThanOrEqualTo(100).WithMessage("Attendance Percentage should be LessThanOrEqualTo 100")

;
}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
