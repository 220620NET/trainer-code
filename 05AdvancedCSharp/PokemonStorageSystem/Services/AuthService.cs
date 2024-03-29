﻿using Models;
using System.Text.Json;
using DataAccess; 
using CustomExceptions;

namespace Services;
public class AuthService
{
    private readonly IPokemonTrainerRepository _repo;

    //dependency injection
    public AuthService(IPokemonTrainerRepository repository)
    {
        _repo = repository;
    }
    public async Task<PokeTrainer> Register(PokeTrainer newTrainer)
    {
        //if you want to keep your name unique in your registry, you can check for duplicates
        //if there is no duplicate record found, then we save this new trainer to our data layer- somewhere
        //First, I need to get the registry, and add it there and then save the new dictionary/collection
        try
        {
            await _repo.GetPokeTrainer(newTrainer.Name);
            throw new DuplicateRecordException();
        }
        catch(RecordNotFoundException)
        {
            //we are g2g with registration
            return _repo.AddPokeTrainer(newTrainer);
        }
    }

    public async Task<PokeTrainer> LogIn(PokeTrainer trainerToFind)
    {
        try
        {
            PokeTrainer foundTrainer =  await _repo.GetPokeTrainer(trainerToFind.Name);
            //I don't have pw set up here, so as long as their name exists they "login"
            //However, if i were to have pw, i'd compare the pw of trainerToFind and foundTrainer and make sure they're the same before "logging them in"

            return foundTrainer;
        }
        catch(RecordNotFoundException)
        {
            throw new InvalidCredentialException();
        }
    }

}
