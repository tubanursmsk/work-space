import express  from "express"
import { userLogin, userLoginDb, userRegister, userRegisterDb } from "../services/userService"
import { IUser } from "../models/userModel"

export const userController = express.Router()

// userLogin
userController.get("/", (req, res) => {
    res.render('login')
})

userController.post('/login', async (req, res) => {
    const user:IUser = req.body
    const isValid = userLogin(user) // servis çağrısı
    if (isValid === true) {
        const userLogin = await userLoginDb(user, req) // Service DB işlemi
        if (userLogin === true) {
            res.redirect('/dashboard') // burayı render yapsak ne olur? bu yazım sayfadaki url kalsın içeriği dahsboard yap demektir.
        }else {
            res.render('login', { error: userLogin })
        }
    } else {
        res.render('login', { error: isValid })
    }
})

userController.get('/logout', (req, res) => {
    req.session.destroy((err) => { // session nesnesi öldürüldü
        if (!err) {
            res.redirect('/')
        }
    })
})

//userRegister
userController.get("/register", (req, res) => {
    res.render("register");
});


userController.post("/register", async (req, res) => {
    const user: IUser = req.body;
    const isValid = userRegister(user);
    if ( isValid === true ) {
        const registerDB = await userRegisterDb(user)
        if (registerDB === true) {
            res.redirect("/");
        } else {
            res.render("register", { error: registerDB });
        }
    } else {
        res.render("register", { error: isValid });
    }
});
