package easyauto.users.service.implent;

import easyauto.users.model.User;
import easyauto.users.repositories.UserRepository;
import easyauto.users.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;


@Service
public class UserServiceImplement implements UserService {

    @Autowired
    private UserRepository userRepository;
    @Override
    public List<User> getAll() {
        return this.userRepository.findAll();
    }

    @Override
    public User getById(String id) {
        return this.userRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Usuário Inexistente!"));
    }

    @Override
    public User create(User user) {
        return this.userRepository.save(user);
    }

    @Override
    public void deleteById(String id) {
        userRepository.deleteById(id);
    }




}
