﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

// Original file: https://github.com/IdentityServer/IdentityServer4.Quickstart.UI
// Modified by D0683497

using System.ComponentModel.DataAnnotations;

namespace Komunumo.Admin.Models.IdentityViewModels.AccountViewModels
{
    public class LoginInputModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberLogin { get; set; }

        public string ReturnUrl { get; set; }
    }
}