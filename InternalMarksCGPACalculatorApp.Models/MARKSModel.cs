namespace InternalMarksCGPACalculatorApp.Models{
			using System;
			using System.ComponentModel.DataAnnotations;
			using Microsoft.AspNetCore.Mvc;
			using System.Collections.Generic;
			using FluentValidation;
			using System.Linq;
			//This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/31/2026 9:49:16 AM
			public class MARKSModel
			{

			 public System.Guid ?MARKSid	{ get; set; }

public int enternumber5{ get; set; }

public int ass11{ get; set; }

public int ass21{ get; set; }

public int int11{ get; set; }

public int int21{ get; set; }

[xssFilter]
public string total1{ get; set; }

[xssFilter]
public string intsub1{ get; set; }

public int ass12{ get; set; }

public int ass22{ get; set; }

public int int12{ get; set; }

public int int22{ get; set; }

[xssFilter]
public string total2{ get; set; }

[xssFilter]
public string intsub2{ get; set; }

public int ass13{ get; set; }

public int ass23{ get; set; }

public int int13{ get; set; }

public int int23{ get; set; }

[xssFilter]
public string total3{ get; set; }

[xssFilter]
public string intsub3{ get; set; }

public int ass14{ get; set; }

public int ass24{ get; set; }

public int int14{ get; set; }

public int int24{ get; set; }

[xssFilter]
public string total4{ get; set; }

[xssFilter]
public string intsub4{ get; set; }

public int ass15{ get; set; }

public int ass25{ get; set; }

public int int15{ get; set; }

public int int25{ get; set; }

[xssFilter]
public string total5{ get; set; }

[xssFilter]
public string intsub5{ get; set; }

public int ass16{ get; set; }

public int ass26{ get; set; }

public int int16{ get; set; }

public int int26{ get; set; }

[xssFilter]
public string total6{ get; set; }

[xssFilter]
public string intsub6{ get; set; }
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
			

			public class MARKSModelValidator: AbstractValidator<MARKSModel>
			{
					 
					public MARKSModelValidator()
					{

						 When(model => model.craftmyapp_actionmethodname == "Add_MARKS", () =>
                                    {
                                        {RuleFor(m => m.enternumber5)
.NotNull().WithMessage("Enter number 5 is required")
.InclusiveBetween(4, 5).WithMessage("Enter number 5 should be between 4 and 5")

;
RuleFor(m => m.ass11)
.NotNull().WithMessage("ASS 11 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 11 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass21)
.NotNull().WithMessage("ASS 21 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 21 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int11)
.NotNull().WithMessage("INT 11 is required")
.LessThanOrEqualTo(60).WithMessage("INT 11 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int21)
.NotNull().WithMessage("INT 21 is required")
.LessThanOrEqualTo(60).WithMessage("INT 21 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total1)
.NotEmpty().WithMessage("Total 1 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 1 is 256 characters or fewer")
;
RuleFor(m => m.intsub1)
.NotEmpty().WithMessage("INT SUB 1 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 1 is 256 characters or fewer")
;
RuleFor(m => m.ass12)
.NotNull().WithMessage("ASS 12 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 12 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass22)
.NotNull().WithMessage("ASS 22 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 22 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int12)
.NotNull().WithMessage("INT 12 is required")
.LessThanOrEqualTo(60).WithMessage("INT 12 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int22)
.NotNull().WithMessage("INT 22 is required")
.LessThanOrEqualTo(60).WithMessage("INT 22 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total2)
.NotEmpty().WithMessage("Total 2 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 2 is 256 characters or fewer")
;
RuleFor(m => m.intsub2)
.NotEmpty().WithMessage("INT SUB 2 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 2 is 256 characters or fewer")
;
RuleFor(m => m.ass13)
.NotNull().WithMessage("ASS 13 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 13 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass23)
.NotNull().WithMessage("ASS 23 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 23 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int13)
.NotNull().WithMessage("INT 13 is required")
.LessThanOrEqualTo(60).WithMessage("INT 13 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int23)
.NotNull().WithMessage("INT 23 is required")
.LessThanOrEqualTo(60).WithMessage("INT 23 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total3)
.NotEmpty().WithMessage("Total 3 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 3 is 256 characters or fewer")
;
RuleFor(m => m.intsub3)
.NotEmpty().WithMessage("INT SUB 3 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 3 is 256 characters or fewer")
;
RuleFor(m => m.ass14)
.NotNull().WithMessage("ASS 14 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 14 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass24)
.NotNull().WithMessage("ASS 24 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 24 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int14)
.NotNull().WithMessage("INT 14 is required")
.LessThanOrEqualTo(60).WithMessage("INT 14 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int24)
.NotNull().WithMessage("INT 24 is required")
.LessThanOrEqualTo(60).WithMessage("INT 24 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total4)
.NotEmpty().WithMessage("Total 4 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 4 is 256 characters or fewer")
;
RuleFor(m => m.intsub4)
.NotEmpty().WithMessage("INT SUB 4 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 4 is 256 characters or fewer")
;
RuleFor(m => m.ass15)
.NotNull().WithMessage("ASS 15 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 15 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass25)
.NotNull().WithMessage("ASS 25 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 25 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int15)
.NotNull().WithMessage("INT 15 is required")
.LessThanOrEqualTo(60).WithMessage("INT 15 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int25)
.NotNull().WithMessage("INT 25 is required")
.LessThanOrEqualTo(60).WithMessage("INT 25 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total5)
.NotEmpty().WithMessage("Total 5 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 5 is 256 characters or fewer")
;
RuleFor(m => m.intsub5)
.NotEmpty().WithMessage("INT SUB 5 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 5 is 256 characters or fewer")
;
RuleFor(m => m.ass16)
.NotNull().WithMessage("ASS 16 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 16 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass26)
.NotNull().WithMessage("ASS 26 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 26 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int16)
.NotNull().WithMessage("INT 16 is required")
.LessThanOrEqualTo(60).WithMessage("INT 16 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int26)
.NotNull().WithMessage("INT 26 is required")
.LessThanOrEqualTo(60).WithMessage("INT 26 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total6)
.NotEmpty().WithMessage("Total 6 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 6 is 256 characters or fewer")
;
RuleFor(m => m.intsub6)
.NotEmpty().WithMessage("INT SUB 6 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 6 is 256 characters or fewer")
;
}

                                    });
When(model => model.craftmyapp_actionmethodname == "Update_MARKS", () =>
                                    {
                                        {RuleFor(m => m.enternumber5)
.NotNull().WithMessage("Enter number 5 is required")
.InclusiveBetween(4, 5).WithMessage("Enter number 5 should be between 4 and 5")

;
RuleFor(m => m.ass11)
.NotNull().WithMessage("ASS 11 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 11 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass21)
.NotNull().WithMessage("ASS 21 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 21 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int11)
.NotNull().WithMessage("INT 11 is required")
.LessThanOrEqualTo(60).WithMessage("INT 11 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int21)
.NotNull().WithMessage("INT 21 is required")
.LessThanOrEqualTo(60).WithMessage("INT 21 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total1)
.NotEmpty().WithMessage("Total 1 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 1 is 256 characters or fewer")
;
RuleFor(m => m.intsub1)
.NotEmpty().WithMessage("INT SUB 1 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 1 is 256 characters or fewer")
;
RuleFor(m => m.ass12)
.NotNull().WithMessage("ASS 12 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 12 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass22)
.NotNull().WithMessage("ASS 22 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 22 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int12)
.NotNull().WithMessage("INT 12 is required")
.LessThanOrEqualTo(60).WithMessage("INT 12 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int22)
.NotNull().WithMessage("INT 22 is required")
.LessThanOrEqualTo(60).WithMessage("INT 22 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total2)
.NotEmpty().WithMessage("Total 2 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 2 is 256 characters or fewer")
;
RuleFor(m => m.intsub2)
.NotEmpty().WithMessage("INT SUB 2 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 2 is 256 characters or fewer")
;
RuleFor(m => m.ass13)
.NotNull().WithMessage("ASS 13 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 13 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass23)
.NotNull().WithMessage("ASS 23 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 23 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int13)
.NotNull().WithMessage("INT 13 is required")
.LessThanOrEqualTo(60).WithMessage("INT 13 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int23)
.NotNull().WithMessage("INT 23 is required")
.LessThanOrEqualTo(60).WithMessage("INT 23 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total3)
.NotEmpty().WithMessage("Total 3 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 3 is 256 characters or fewer")
;
RuleFor(m => m.intsub3)
.NotEmpty().WithMessage("INT SUB 3 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 3 is 256 characters or fewer")
;
RuleFor(m => m.ass14)
.NotNull().WithMessage("ASS 14 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 14 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass24)
.NotNull().WithMessage("ASS 24 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 24 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int14)
.NotNull().WithMessage("INT 14 is required")
.LessThanOrEqualTo(60).WithMessage("INT 14 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int24)
.NotNull().WithMessage("INT 24 is required")
.LessThanOrEqualTo(60).WithMessage("INT 24 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total4)
.NotEmpty().WithMessage("Total 4 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 4 is 256 characters or fewer")
;
RuleFor(m => m.intsub4)
.NotEmpty().WithMessage("INT SUB 4 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 4 is 256 characters or fewer")
;
RuleFor(m => m.ass15)
.NotNull().WithMessage("ASS 15 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 15 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass25)
.NotNull().WithMessage("ASS 25 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 25 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int15)
.NotNull().WithMessage("INT 15 is required")
.LessThanOrEqualTo(60).WithMessage("INT 15 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int25)
.NotNull().WithMessage("INT 25 is required")
.LessThanOrEqualTo(60).WithMessage("INT 25 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total5)
.NotEmpty().WithMessage("Total 5 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 5 is 256 characters or fewer")
;
RuleFor(m => m.intsub5)
.NotEmpty().WithMessage("INT SUB 5 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 5 is 256 characters or fewer")
;
RuleFor(m => m.ass16)
.NotNull().WithMessage("ASS 16 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 16 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.ass26)
.NotNull().WithMessage("ASS 26 is required")
.LessThanOrEqualTo(40).WithMessage("ASS 26 should be LessThanOrEqualTo 40")

;
RuleFor(m => m.int16)
.NotNull().WithMessage("INT 16 is required")
.LessThanOrEqualTo(60).WithMessage("INT 16 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.int26)
.NotNull().WithMessage("INT 26 is required")
.LessThanOrEqualTo(60).WithMessage("INT 26 should be LessThanOrEqualTo 60")

;
RuleFor(m => m.total6)
.NotEmpty().WithMessage("Total 6 is required")
.MaximumLength(256).WithMessage("The allowed length of Total 6 is 256 characters or fewer")
;
RuleFor(m => m.intsub6)
.NotEmpty().WithMessage("INT SUB 6 is required")
.MaximumLength(256).WithMessage("The allowed length of INT SUB 6 is 256 characters or fewer")
;
}

                                    });

						 
						
					}

			}

                

                

                
 

                

                

        

			}
