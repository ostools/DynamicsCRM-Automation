using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Stubs {
  public class TestDiscoveryServiceAdapter : IDiscoveryServiceAdapter {
    private readonly string _discoveryServiceUrl;
    public List<OrganizationDetail> OrganizationDetails { get; set; }
    public string Url { get; set; }

    public TestDiscoveryServiceAdapter(string discoveryServiceUrl) {
      _discoveryServiceUrl = discoveryServiceUrl;
    }

    public IEnumerable<OrganizationDetail> DiscoverOrganizations() {
      return OrganizationDetails;
    }

    public bool IsDiscoverable() {
      return true;
    }
  }
}