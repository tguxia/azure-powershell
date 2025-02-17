﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
using Microsoft.Azure.Commands.ServiceBus.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using System.Linq;
using System.Management.Automation;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.ServiceBus.Commands.NetworkruleSet
{
    /// <summary>
    /// 'Set-AzEventHubNamespace' Cmdlet updates the specified Eventhub Namespace
    /// </summary>
    [GenericBreakingChange(message: BreakingChangeNotification + "\n- Output type of the cmdlet would change to 'Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.INetworkRuleSet'", deprecateByVersion: DeprecateByVersion, changeInEfectByDate: ChangeInEffectByDate)]
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ServiceBusNetworkRuleSet", SupportsShouldProcess = true, DefaultParameterSetName = NetworkRuleSetPropertiesParameterSet), OutputType(typeof(PSNetworkRuleSetAttributes))]
    public class SetAzureServiceBusNetworkrule : AzureServiceBusCmdletBase
    {
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetInputObjectParameterSet, Position = 0, HelpMessage = "Resource Group Name.")]
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetPropertiesParameterSet, Position = 0, HelpMessage = "Resource Group Name.")]
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetResourceIdParameterSet, Position = 0, HelpMessage = "Resource Group Name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
         public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetInputObjectParameterSet, Position = 1, HelpMessage = "ServiceBus Namespace Name.")]
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetPropertiesParameterSet, Position = 1, HelpMessage = "ServiceBus Namespace Name.")]
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetResourceIdParameterSet, Position = 1, HelpMessage = "ServiceBus Namespace Name.")]
        [ValidateNotNullOrEmpty]
        [Alias(AliasNamespaceName)]
        public string Name { get; set; }       

        [Parameter(Mandatory = false, ParameterSetName = NetworkRuleSetPropertiesParameterSet, HelpMessage = "Default Action for NetwrokeuleSet")]
        [PSArgumentCompleter("Allow", "Deny")]
        [PSDefaultValue(Value ="Deny")]
        public string DefaultAction { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = NetworkRuleSetPropertiesParameterSet, HelpMessage = "Public Network Access for NetwrokeuleSet")]
        [PSArgumentCompleter("Enabled", "Disabled")]
        [PSDefaultValue(Value = "Enabled")]
        public string PublicNetworkAccess { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = NetworkRuleSetPropertiesParameterSet, HelpMessage = "Trusted Service Access for NetworkRuleSet")]
        public SwitchParameter TrustedServiceAccessEnabled { get; set; }

        [CmdletParameterBreakingChange("IPRule", OldParamaterType = typeof(PSNWRuleSetIpRulesAttributes[]), NewParameterTypeName = "Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.INwRuleSetIPRules[]")]
        [Parameter(Mandatory = false, ParameterSetName = NetworkRuleSetPropertiesParameterSet, Position = 2, HelpMessage = "List of IPRuleSet")]
        public PSNWRuleSetIpRulesAttributes[] IPRule { get; set; }

        [CmdletParameterBreakingChange("VirtualNetworkRule", OldParamaterType = typeof(PSNWRuleSetVirtualNetworkRulesAttributes[]), NewParameterTypeName = "Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.INwRuleSetVirtualNetworkRules[]")]
        [Parameter(Mandatory = false, ParameterSetName = NetworkRuleSetPropertiesParameterSet, Position = 3, HelpMessage = "List of VirtualNetworkRules")]
        [Alias(AliasVirtualNetworkRule)]
        public PSNWRuleSetVirtualNetworkRulesAttributes[] VirtualNetworkRule { get; set; }

        [CmdletParameterBreakingChange("InputObject", OldParamaterType = typeof(PSNetworkRuleSetAttributes), NewParameterTypeName = "Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202201Preview.INetworkRuleSet", ChangeDescription = NetworkRuleSetInputObjectParameterSet + " parameter set is changing. Please refer the migration guide for examples.")]
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetInputObjectParameterSet, ValueFromPipeline = true, Position = 2, HelpMessage = "NetworkruleSet Configuration Object")]
        [ValidateNotNullOrEmpty]
        public PSNetworkRuleSetAttributes InputObject { get; set; }

        [CmdletParameterBreakingChange("ResourceId", ReplaceMentCmdletParameterName = "InputObject")]
        [Parameter(Mandatory = true, ParameterSetName = NetworkRuleSetResourceIdParameterSet, ValueFromPipelineByPropertyName = true, Position = 2, HelpMessage = "Resource ID of Namespace")]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }


        public override void ExecuteCmdlet()
        {
            // Update the NetworlruleSet 
            
            if (ShouldProcess(target: Name, action: string.Format("Update NetworkruleSet for {0} Namespace in {1} ResourceGroup", Name, ResourceGroupName)))
            {
                try
                {

                    if (ParameterSetName.Equals(NetworkRuleSetPropertiesParameterSet))
                    {
                        bool? trustedServiceAccessEnabled = null;

                        if (this.IsParameterBound(c => c.TrustedServiceAccessEnabled) == true)
                        {
                            trustedServiceAccessEnabled = TrustedServiceAccessEnabled.IsPresent;
                        }


                        WriteObject(Client.UpdateNetworkRuleSet(resourceGroupName: ResourceGroupName, 
                                                                namespaceName: Name, 
                                                                publicNetworkAccess: PublicNetworkAccess,
                                                                trustedServiceAccessEnabled: trustedServiceAccessEnabled,
                                                                defaultAction: DefaultAction,
                                                                iPRule: IPRule,
                                                                virtualNetworkRule: VirtualNetworkRule));
                    }

                    if (ParameterSetName.Equals(NetworkRuleSetInputObjectParameterSet))
                    {
                        WriteObject(Client.CreateOrUpdateNetworkRuleSet(ResourceGroupName, Name, InputObject));
                    }

                    if (ParameterSetName.Equals("NetworkRuleSetResourceIdParameterSet"))
                    {
                        ResourceIdentifier getParamGeoDR = GetResourceDetailsFromId(ResourceId);

                        PSNetworkRuleSetAttributes getNWRuleSet = Client.GetNetworkRuleSet(getParamGeoDR.ResourceGroupName, getParamGeoDR.ParentResource);

                        if (ResourceGroupName != null && getParamGeoDR.ResourceName != null)
                        {
                            if (ShouldProcess(target: Name, action: string.Format("updating NetworkRuleSet", Name, ResourceGroupName)))
                            {
                                WriteObject(Client.CreateOrUpdateNetworkRuleSet(ResourceGroupName, Name, getNWRuleSet));
                            }
                        }
                    }
                }
                catch (Management.ServiceBus.Models.ErrorResponseException ex)
                {
                    WriteError(ServiceBusClient.WriteErrorforBadrequest(ex));
                }
            }
        }
    }
}
