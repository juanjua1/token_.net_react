import axios from 'axios';

const API_URL = 'https://localhost:5001/api/auth';

class AuthService {
    login(username, password) {
        return axios.post(API_URL + '/login', { username, password })
            .then(response => {
                if (response.data.token) {
                    localStorage.setItem('user', JSON.stringify(response.data));
                }
                return response.data;
            });
    }

    logout() {
        localStorage.removeItem('user');
    }

    getCurrentUser() {
        return JSON.parse(localStorage.getItem('user'));
    }
}

export default new AuthService();
