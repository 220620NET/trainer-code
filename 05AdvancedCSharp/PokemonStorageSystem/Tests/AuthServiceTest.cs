using Moq;
using Models;
using CustomExceptions;
using Services;
using DataAccess;
using System;
using Xunit;
using System.Threading.Tasks;

namespace Tests;

public class AuthServiceTest
{
    //I'm testing the successful registration scenario here
    [Fact]
    public async Task RegisterShouldRegisterNonExistingUser()
    {
        // Arrange
        var mockedRepo = new Mock<IPokemonTrainerRepository>();
        //fixing a this to a certain date time so our poketrainer objects can all use this. 
        DateTime now = DateTime.Now;

        PokeTrainer trainerToAdd = new PokeTrainer{
            Name = "test pokemon trainer",
            NumBadges = 2,
            Money = 100,
            DoB = now
        };

        PokeTrainer trainerToReturn = new PokeTrainer{
            Id = 1,
            Name = "test pokemon trainer",
            NumBadges = 2,
            Money = 100,
            DoB = now
        };

        mockedRepo.Setup(repo => repo.GetPokeTrainer(trainerToAdd.Name)).Throws(new RecordNotFoundException());
        mockedRepo.Setup(repo => repo.AddPokeTrainer(trainerToAdd)).Returns(trainerToReturn);

        AuthService service = new AuthService(mockedRepo.Object);

        //Act
        PokeTrainer returnedTrainer = await service.Register(trainerToAdd);

        //Assert (Verification)
        mockedRepo.Verify(repo => repo.GetPokeTrainer(trainerToAdd.Name), Times.Once());
        mockedRepo.Verify(repo => repo.AddPokeTrainer(trainerToAdd), Times.Once());

        //Verifying that the returned result is the same as what we've sent as well as what we've had the mock repository to respond with
        Assert.NotNull(returnedTrainer);
        Assert.Equal(returnedTrainer.Id, trainerToReturn.Id);
        Assert.Equal(returnedTrainer.Name, trainerToAdd.Name);
    }

    //I'm testing the failure registration scenario
    [Fact]
    public void RegisterShouldNotRegisterExistingUser()
    {
        // Arrange
        var mockedRepo = new Mock<IPokemonTrainerRepository>();
        //fixing a this to a certain date time so our poketrainer objects can all use this. 
        DateTime now = DateTime.Now;

        PokeTrainer trainerToAdd = new PokeTrainer{
            Name = "test pokemon trainer",
            NumBadges = 2,
            Money = 100,
            DoB = now
        };

        PokeTrainer trainerToReturn = new PokeTrainer{
            Id = 1,
            Name = "test pokemon trainer",
            NumBadges = 2,
            Money = 100,
            DoB = now
        };

        mockedRepo.Setup(repo => repo.GetPokeTrainer(trainerToAdd.Name)).ReturnsAsync(trainerToReturn);

        AuthService service = new AuthService(mockedRepo.Object);

        //Act + Assert (Verification)
        Assert.ThrowsAsync<DuplicateRecordException>(() => service.Register(trainerToAdd));
        
        mockedRepo.Verify(repo => repo.GetPokeTrainer(trainerToAdd.Name), Times.Once());
    }
}