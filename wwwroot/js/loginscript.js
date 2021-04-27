const name = document.getElementById('username')
const password = document.getElementById('password')
const form = document.getElementById('login-form')
const errorElement = document.getElementById('error')

form.addEventListener('submit', (e) => {
    let messages = []
    if (name.value === '' || name.value == null) {
        messages.push('Username is required')
    }

    if (password.value.length <= 7) {
        messages.push('Password must be longer than 7 characters')
    }

    if (password.value.length >= 10) {
        messages.push('Password must be less than 10 characters')
    }

    if (password.value === 'password') {
        messages.push('Password must be unique')
    }

    if (messages.length > 0) {
        e.preventDefault()
        errorElement.innerText = messages.join(', ')
    }
})