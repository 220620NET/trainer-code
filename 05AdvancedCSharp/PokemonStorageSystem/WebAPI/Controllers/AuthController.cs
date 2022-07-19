﻿using Services;
using Models;
using CustomExceptions;

namespace WebAPI.Controllers;
public class AuthController
{
    private readonly AuthService _service;
    public AuthController(AuthService service)
    {
        _service = service;
    }

    public async Task<IResult> Register(PokeTrainer trainerToRegister)
    {
        if (trainerToRegister.Name == null)
        {
            return Results.BadRequest("Name cannot be null");
        }
        try
        {
            await _service.Register(trainerToRegister);
            return Results.Created("/register", trainerToRegister);
        }
        catch (DuplicateRecordException)
        {
            return Results.Conflict("Trainer with this name already exists");
        }
    }

        public async Task<IResult> Login(PokeTrainer trainerToLogin)
    {
        if (trainerToLogin.Name == null)
        {
            return Results.BadRequest("Name cannot be null");
        }
        try
        {
            return Results.Ok(await _service.LogIn(trainerToLogin));
        }
        catch (InvalidCredentialException)
        {
            return Results.NoContent();
        }
    }
}
