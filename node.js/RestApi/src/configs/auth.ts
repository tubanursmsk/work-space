import { Request, Response, NextFunction } from "express"; //Express middleware yapısında gereklidir.
import jwt, { JwtPayload } from "jsonwebtoken";//Token üretmek ve doğrulamak için kullanılır.
import { jsonResult } from "../models/result";//Standart API cevabı formatını sağlar.
import { eRoles } from "../utils/eRoles";//Sistemdeki rollerin enum hâli (Admin, User, Editor vs).

export const SECRET_KEY = process.env.SECRET_KEY || 'your_secret_key'; //.env dosyasındaki gizli anahtar burada tutulur.
 //JWT (JSON Web Token) üretiminde ve doğrulamada şifreleme anahtarı olarak kullanılır. Eğer dışarı sızarsa herkes token üretebilir — bu yüzden .env içinde gizli tutulur.

export interface AuthRequest extends Request {
  user?: string | JwtPayload;
}

export function verifyToken(req: AuthRequest, res: Response, next: NextFunction) {
  const authHeader = req.headers["authorization"];
  if (!authHeader) return jsonResult(403, false, "Token empty!", null);

  const token = authHeader.split(" ")[1];
  if (!token) return jsonResult(403, false, "Token missing!", null);

  jwt.verify(token, SECRET_KEY, (err, user) => {
    if (err) return jsonResult(403, false, "Invalid token", null);
    req.user = user;
    next();
  });
}

export function checkRole(...roles: eRoles[]) { //birden fazla parametreyi tek bir roles dizisinde topladık.
  return (req: AuthRequest, res: Response, next: NextFunction) => {
    const user = req.user as JwtPayload;
    const userRoles = user.roles;
    // Kullanıcının rolleri roles dizisinde var mı kontrolü
    const hasRole = userRoles
      .map(r => r.toLowerCase())
      .some(r => roles.map(rr => rr.toLowerCase()).includes(r));
    if (!hasRole) {
      const result = jsonResult(403, false, "You do not have permission for this action", null);
      return res.status(403).json(result);
    }
    next();
  };
}