using Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities;
using Education_platform.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Education_platform.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        public ActionResult<UserEntity> GetAll()
        {
            var users = _userService.GetAll();

            if (users == null)
            {
                return BadRequest("User list is empty");
            }
            return View(users);
        }

        [HttpGet]
        public ActionResult Add() => View();
        public async Task<ActionResult<UserEntity>> Add(UserEntity user)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.Add(user);
                return View(result);
            }
            else
            {
                string errorMessages = "";
                foreach (var item in ModelState)
                {
                    // если для определенного элемента имеются ошибки
                    if (item.Value.ValidationState == ModelValidationState.Invalid)
                    {
                        errorMessages = $"{errorMessages}\nОшибки для свойства {item.Key}:\n";
                        // пробегаемся по всем ошибкам
                        foreach (var error in item.Value.Errors)
                        {
                            errorMessages = $"{errorMessages}{error.ErrorMessage}\n";
                        }
                    }
                }
                return View(errorMessages);
            }
        }
    }
    /* [HttpGet]
    public async Task Index()
    {
       *//* string content = @"<form method='post'>
            <label>Name:</label><br />
            <input name='name' /><br />
            <label>Age:</label><br />
            <input type='number' name='age' /><br />
            <input type='submit' value='Send' />
        </form>";
        Response.ContentType = "text/html;charset=utf-8";
        await Response.WriteAsync(content);*//*
    }
    [HttpPost]
    public string Index(string name, int age) => $"{name}: {age}";

    // GET: UserController
  *//*  public ActionResult Index()
    {
        return View();
    }*//*

    // GET: UserController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: UserController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: UserController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: UserController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: UserController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: UserController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: UserController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }*/
}

