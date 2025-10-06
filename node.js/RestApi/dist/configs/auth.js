"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.SECRET_KEY = void 0;
exports.verifyToken = verifyToken;
exports.checkRole = checkRole;
const jsonwebtoken_1 = __importDefault(require("jsonwebtoken"));
const result_1 = require("../models/result");
exports.SECRET_KEY = process.env.SECRET_KEY || 'your_secret_key';
function verifyToken(req, res, next) {
    const authHeader = req.headers["authorization"];
    if (!authHeader)
        return (0, result_1.jsonResult)(403, false, "Token empty!", null);
    const token = authHeader.split(" ")[1];
    if (!token)
        return (0, result_1.jsonResult)(403, false, "Token missing!", null);
    jsonwebtoken_1.default.verify(token, exports.SECRET_KEY, (err, user) => {
        if (err)
            return (0, result_1.jsonResult)(403, false, "Invalid token", null);
        req.user = user;
        next();
    });
}
function checkRole(role) {
    return (req, res, next) => {
        const user = req.user;
        if (user.role !== role) {
            return (0, result_1.jsonResult)(403, false, "You do not have permission for this action", null);
        }
        next();
    };
}
//# sourceMappingURL=auth.js.map