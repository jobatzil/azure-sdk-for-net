// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Allows to disable rules within a rule group or an entire rule group.
    /// </summary>
    public partial class ApplicationGatewayFirewallDisabledRuleGroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayFirewallDisabledRuleGroup class.
        /// </summary>
        public ApplicationGatewayFirewallDisabledRuleGroup() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayFirewallDisabledRuleGroup class.
        /// </summary>
        /// <param name="ruleGroupName">The name of the rule group that will be
        /// disabled.</param>
        /// <param name="rules">The list of rules that will be disabled. If
        /// empty, all rules of the rule group will be disabled.</param>
        public ApplicationGatewayFirewallDisabledRuleGroup(string ruleGroupName, IList<int?> rules = default(IList<int?>))
        {
            RuleGroupName = ruleGroupName;
            Rules = rules;
        }

        /// <summary>
        /// Gets or sets the name of the rule group that will be disabled.
        /// </summary>
        [JsonProperty(PropertyName = "ruleGroupName")]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// Gets or sets the list of rules that will be disabled. If empty, all
        /// rules of the rule group will be disabled.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<int?> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RuleGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleGroupName");
            }
        }
    }
}
