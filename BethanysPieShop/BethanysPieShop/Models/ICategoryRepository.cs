﻿namespace BethanysPieShop.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> GetAll();
}