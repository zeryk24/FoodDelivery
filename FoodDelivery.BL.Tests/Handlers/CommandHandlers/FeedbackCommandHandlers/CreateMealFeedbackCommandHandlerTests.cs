using System.Security.Claims;
using FoodDelivery.BL.Commands.AddressCommands;
using FoodDelivery.BL.Commands.FeedbackCommands;
using FoodDelivery.BL.Handlers.CommandHandlers.AddressCommandHandlers;
using FoodDelivery.BL.Handlers.CommandHandlers.FeedbackCommandHandlers;
using FoodDelivery.DAL.EFCore.Entities;
using FoodDelivery.DAL.Entities;
using FoodDelivery.Shared.Models.AddressModels;
using FoodDelivery.Shared.Models.FeedbacksModels;
using Moq;

namespace FoodDelivery.BL.Tests.Handlers.CommandHandlers.FeedbackCommandHandlers;

public class CreateMealFeedbackCommandHandlerTests : IClassFixture<FeedbackFixture>, IClassFixture<HandlerFixture>
{
    private readonly FeedbackFixture _feedbackFixture;
    private readonly HandlerFixture _handlerFixture;
    private ClaimsPrincipal _user;

    public CreateMealFeedbackCommandHandlerTests(FeedbackFixture feedbackFixture, HandlerFixture handlerFixture)
    {
        _feedbackFixture = feedbackFixture;
        _handlerFixture = handlerFixture;
        
        handlerFixture.FeedbackRepositoryMock.Setup(f => f.Insert(It.IsAny<FeedbackEntity>()));
        handlerFixture.UnitOfWorkMock.SetupGet(u => u.FeedbackRepository)
            .Returns(handlerFixture.FeedbackRepositoryMock.Object);
        handlerFixture.UnitOfWorkProviderMock.Setup(u => u.Create())
            .Returns(handlerFixture.UnitOfWorkMock.Object);
        handlerFixture.MapperMock.Setup(m => m.Map<FeedbackEntity>(feedbackFixture.MealFeedbackCreateModel))
            .Returns(feedbackFixture.MealFeedbackEntity);
        handlerFixture.MapperMock.Setup(m => m.Map<FeedbackDetailModel>(feedbackFixture.MealFeedbackEntity))
            .Returns(feedbackFixture.MealFeedbackDetailModel);
        _user = new ClaimsPrincipal();
        handlerFixture.UserManagerMock.Setup(u => u.GetUserAsync(_user))
            .ReturnsAsync(new UserEntity
            {
                Id = 1,
            });
    }

    [Fact]
    public async Task Handle_ValidRequest_ValidResult()
    {
        var request = new CreateMealFeedbackCommand(_feedbackFixture.MealFeedbackCreateModel, _user);
        var handler = new CreateMealFeedbackCommandHandler(_handlerFixture.UnitOfWorkProviderMock.Object,
            _handlerFixture.MapperMock.Object,
            _handlerFixture.UserManagerMock.Object);

        var expected = _feedbackFixture.MealFeedbackDetailModel;
        var actual = await handler.Handle(request, CancellationToken.None);

        Assert.Equal(expected, actual);
    }
}