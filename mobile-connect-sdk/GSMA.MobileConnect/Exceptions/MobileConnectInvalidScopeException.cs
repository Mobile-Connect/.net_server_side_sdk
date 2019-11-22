﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMA.MobileConnect.Exceptions
{
    /// <summary>
    /// Invalid Scope Exception
    /// </summary>
    public class MobileConnectInvalidScopeException : Exception
    {
        private const string MESSAGE = "Failed to process the scope: {0}. The scope doesn't support (scope isn't correct or doesn't match with version)";
        private string scope = null;

        /// <inheritdoc/>
        public MobileConnectInvalidScopeException(string scope) : base(GetMessage(scope))
        {
            Log.Warning(GetMessage(scope));
            this.scope = scope;
        }

        public MobileConnectStatus ToMobileConnectStatus()
        {
            return MobileConnectStatus.Error("invalid_scope", GetMessage(this.scope), this);
        }

        private static string GetMessage(string scope)
        {
            return string.Format(MESSAGE, scope);
        }

       
    }
}