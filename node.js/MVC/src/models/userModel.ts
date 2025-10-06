import mongoose, { Document, Schema } from "mongoose";

export interface IUser extends Document {
    name: string,
    email: string,
    password: string,
    date?: Date
}
const UserSchema: Schema<IUser> = new Schema({
    name: {type: String, required: true},
    email: {type: String, required: true, unique: true},
    password: {type: String, required: true},
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