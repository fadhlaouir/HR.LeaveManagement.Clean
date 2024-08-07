﻿using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

public class LeaveRequest : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public LeaveType? LeaveType { get; set; }

    public int LeaveTypeId { get; set; }

    public DateTime DateRequest { get; set; }
    public string? RequestComments { get; set; }

    public string? Approved { get; set; }

    public bool Cancelled { get; set; }

    public string RequestingEmployeeId { get; set; } = string.Empty;
}
