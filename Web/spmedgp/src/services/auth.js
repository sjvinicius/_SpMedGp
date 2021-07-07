export default function tokenDecode(token) {
    
    token = localStorage.getItem('token-userup').split('.')[1];

    return JSON.parse(window.atob(token));

}