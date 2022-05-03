package easyauto.users.controller;

import easyauto.users.model.User;
import easyauto.users.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;

import java.util.List;


@RestController
@RequestMapping("/users")
public class UserController {

    @Autowired
    private UserService userService;

    @PostMapping//create
    public User create(@RequestBody User user){
        return this.userService.create(user);
    }

    @GetMapping//read
    public List<User> getAll() {
        return this.userService.getAll();
    }

    @GetMapping("/{id}")//read
    public User getById(@PathVariable String id){
        return this.userService.getById(id);
    }



    @DeleteMapping("/{id}")//delete
    //@ResponseStatus(HttpStatus.NO_CONTENT)
    public void deleteById(@PathVariable String id) throws Exception{
        userService.deleteById(id);
    }




}
