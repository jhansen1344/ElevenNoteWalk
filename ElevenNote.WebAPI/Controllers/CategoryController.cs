﻿using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        public IHttpActionResult Post(CategoryCreate category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCategoryService();
            if (!service.CreateCategory(category))
                return InternalServerError();
            return Ok();
        }

        public IHttpActionResult Get()
        {
            CategoryService service = CreateCategoryService();
            var categories = service.GetCategories();
            return Ok(categories);
        }

        public IHttpActionResult Get(int id)
        {
            var service = CreateCategoryService();
            var category = service.GetCategoryById(id);
            return Ok(category);
        }

        public IHttpActionResult Put(CategoryEdit category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCategoryService();
            if (!service.UpdateCategory(category))
                return InternalServerError();
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateCategoryService();
            if (!service.DeleteCategory(id))
                return InternalServerError();
            return Ok();
        }


        private CategoryService CreateCategoryService()
        {
            //var userID = Guid.Parse(User.Identity.GetUserId());
            var categoryService = new CategoryService();
            return categoryService;
        }
    }
}