import mongoose, { Document, Schema } from "mongoose";

export interface IUser extends Document {
    name: string,
    email: string,
    password: string,
    roles: string[],
    jwt?: string,
    date?: Date
}
const UserSchema: Schema<IUser> = new Schema({
    name: {type: String, required: true},
    email: {type: String, required: true, unique: true, min: 6},
    password: {type: String, required: true},
    roles: {type: [String], default: ['user']}, // [String] → Mongoose şeması için doğru ve geçerli yazımdır. String[] → TypeScript tip tanımıdır, Mongoose şemasında kullanılmaz. String[], alanın bir dizi (array) olacağını ve elemanlarının tipinin String olacağını belirtir.
    jwt: {type: String},
    date: {
        type: Date,
        default: () => {
            const now = new Date();
            return now.setHours(now.getHours() + 3)
        }
    }
})

const UserDB = mongoose.model<IUser>('User', UserSchema)

export default UserDB