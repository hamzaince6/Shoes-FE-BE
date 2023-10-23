﻿namespace DataAccessLayer.Abstract;

public interface IGenericDal <T> where T: class
{
    void Insert(T t);
    
    void Delete(T t);
    
    void Update(T t);
    
    List <T> GetListAll();
    
    T GetByID(int id);
    
}