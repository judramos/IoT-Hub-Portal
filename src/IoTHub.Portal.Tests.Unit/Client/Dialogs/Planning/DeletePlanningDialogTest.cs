// Copyright (c) CGI France. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace IoTHub.Portal.Tests.Unit.Client.Dialogs.Planning
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using IoTHub.Portal.Client.Dialogs.Planning;
    using MudBlazor;

    [TestFixture]
    public class DeletePlanningDialogTest : BlazorUnitTest
    {
        private Mock<IPlanningClientService> mockPlanningClientService;
        private Mock<ILayerClientService> mockLayerClientService;

        public override void Setup()
        {
            base.Setup();

            this.mockPlanningClientService = MockRepository.Create<IPlanningClientService>();
            this.mockLayerClientService = MockRepository.Create<ILayerClientService>();

            _ = Services.AddSingleton(this.mockPlanningClientService.Object);
            _ = Services.AddSingleton(this.mockLayerClientService.Object);
        }

        [Test]
        public async Task DeletePlanning_PlanningDeleted()
        {
            // Arrange
            var planningId = Guid.NewGuid().ToString();
            var planningName = Guid.NewGuid().ToString();

            _ = this.mockLayerClientService.Setup(service => service.GetLayers())
                .ReturnsAsync(new List<LayerDto>());

            _ = this.mockPlanningClientService.Setup(service => service.DeletePlanning(planningId))
                .Returns(Task.CompletedTask);

            var cut = RenderComponent<MudDialogProvider>();
            var service = Services.GetService<IDialogService>() as DialogService;

            var parameters = new DialogParameters
            {
                {"planningID", planningId},
                {"planningName", planningName}
            };

            // Act
            _ = await cut.InvokeAsync(() => service?.Show<DeletePlanningDialog>(string.Empty, parameters));
            cut.WaitForElement("#delete-planning").Click();

            // Assert
            cut.WaitForAssertion(() => MockRepository.VerifyAll());
        }

        [Test]
        public async Task OnClickOnCancelShouldCancelDialog2()
        {
            // Arrange
            var planningId = Guid.NewGuid().ToString();
            var planningName = Guid.NewGuid().ToString();

            _ = this.mockLayerClientService.Setup(service => service.GetLayers())
                .ReturnsAsync(new List<LayerDto>());

            var cut = RenderComponent<MudDialogProvider>();
            var dialogService = Services.GetService<IDialogService>() as DialogService;

            var parameters = new DialogParameters
            {
                {"planningID", planningId},
                {"planningName", planningName}
            };

            IDialogReference dialogReference = null;

            _ = await cut.InvokeAsync(() => dialogReference = dialogService?.Show<DeletePlanningDialog>(string.Empty, parameters));
            cut.WaitForAssertion(() => cut.Find("#cancel-delete-planning"));

            // Act
            cut.Find("#cancel-delete-planning").Click();
            var result = await dialogReference.Result;

            // Assert
            _ = result.Canceled.Should().BeTrue();
            cut.WaitForAssertion(() => MockRepository.VerifyAll());
        }
    }
}