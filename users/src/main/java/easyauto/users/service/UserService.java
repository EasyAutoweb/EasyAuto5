package easyauto.users.service;

import easyauto.users.model.User;

import java.util.List;

public interface UserService {

    public List<User> getAll();

    public User getById(String id);

    public User create(User user);

    public void deleteById(String id);




}
