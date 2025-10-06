"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.login = exports.register = void 0;
const result_1 = require("../models/result");
const userModel_1 = __importDefault(require("../models/userModel"));
const bcrypt_1 = __importDefault(require("bcrypt"));
const register = (user) => __awaiter(void 0, void 0, void 0, function* () {
    // find user - email control
    const findUser = yield userModel_1.default.findOne({ email: user.email });
    if (findUser) {
        return (0, result_1.jsonResult)(400, false, 'User already exists', user);
    }
    else {
        try {
            const bcryptPassword = yield bcrypt_1.default.hash(user.password, 10);
            const newUser = new userModel_1.default(Object.assign(Object.assign({}, user), { password: bcryptPassword }));
            yield newUser.save();
            return (0, result_1.jsonResult)(201, true, 'User created successfully', newUser);
        }
        catch (error) {
            return (0, result_1.jsonResult)(500, false, 'Internal server error', error.message);
        }
    }
});
exports.register = register;
const login = (user) => __awaiter(void 0, void 0, void 0, function* () {
    const findUser = yield userModel_1.default.findOne({ email: user.email });
    if (findUser) {
        const checkPassword = yield bcrypt_1.default.compare(user.password, findUser.password);
        if (checkPassword) {
            findUser.jwt = 'fake-jwt-token';
            return (0, result_1.jsonResult)(200, true, 'Login successful', findUser);
        }
        else {
            return (0, result_1.jsonResult)(404, false, 'E-mail or Password is incorrect', user);
        }
    }
    else {
        return (0, result_1.jsonResult)(404, false, 'E-mail or Password is incorrect', user);
    }
});
exports.login = login;
//# sourceMappingURL=userService.js.map