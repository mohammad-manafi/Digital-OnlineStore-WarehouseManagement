using FluentAssertions;
using Newtonsoft.Json;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Warehouse.Application.Contract;
using Warehouse.Tests.E2E.Tools;

namespace Warehouse.Tests.E2E.Steps
{
    [Binding]
    public class WarehouseManagementSteps
    {
        private bool _postResult;
        private DefineWarehouse _Command;
       
        [Given(@"I want to add the following inventory to my warehouse")]
        public void GivenIWantToAddTheFollowingInventoryToMyWarehouse(Table table)
        {
            _Command = table.CreateInstance<DefineWarehouse>();
        }
        
        [When(@"I Try To Define This Inventory")]
        public void WhenITryToDefineThisInventory()
        {
             var restClient = new RestClient(HostConstants.Endpoint);
             var restRequest = new RestRequest("Warehouse");
             restRequest.AddJsonBody(_Command);
             var response = restClient.Post(restRequest);
             _postResult = JsonConvert.DeserializeObject<bool>(response.Content);
        }
        
        [Then(@"The Inventory Should Be Created")]
        public void ThenTheInventoryShouldBeCreated()
        {
            _postResult.Should().BeTrue();
        }
        
        [Then(@"It Should Be Empty")]
        public void ThenItShouldBeEmpty()
        {
            
        }
    }
}
