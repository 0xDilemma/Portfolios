﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BackMange.Models;

public partial class TUserNotification
{
    public int FNotificationId { get; set; }

    public int FUserId { get; set; }

    public string FMessage { get; set; }

    public int? FRelatedId { get; set; }

    public int? FSenderId { get; set; }

    public string FNotifyType { get; set; }

    public bool FIsRead { get; set; }

    public DateTime? FCreatedAt { get; set; }

    public virtual TUser FSender { get; set; }

    public virtual TUser FUser { get; set; }
}