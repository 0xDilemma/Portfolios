﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BackMange.Models;

public partial class TVerification
{
    public int FverificationId { get; set; }

    public int FuserId { get; set; }

    public string Ftoken { get; set; }

    public string FtokenType { get; set; }

    public DateTime? FtokenSentTime { get; set; }

    public DateTime FexpirationTime { get; set; }

    public bool? FisUsed { get; set; }

    public DateTime? FusedTime { get; set; }

    public virtual TUser Fuser { get; set; }
}